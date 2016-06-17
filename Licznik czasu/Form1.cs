using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OEE.Data.DataModel;
using System.IO.Ports;
using System.Configuration;
using System.Management.Instrumentation;
using System.Management;

namespace Licznik_czasu
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Ilość sekund jaka upłynęła od ostatniego odczytu z arduino
        /// </summary>
        public int Odstep { get; set; }

        /// <summary>
        /// Maksymalna liczba sekund pomiędzy sztukami
        /// </summary>
        public int MaxOdstep { get; set; }

        /// <summary>
        /// Nazwa linii produkcyjnej
        /// </summary>
        public string LiniaProdukcyjna { get; set; }

        /// <summary>
        /// Port na którym nadaje arduino
        /// ustawiony jest w App.config
        /// </summary>
        public string ArduinoPort { get; set; }
        #region properties
        //właściwości formularza
        public TypZdarzenia ObecnyStan { get; set; }
        public DateTime CzasUruchomienia { get; set; }
        public int CzasTrwania { get; set; }
        LicznikDataModel db = new LicznikDataModel();
        public int Brygada { get; set; }
        public float Tempo { get; set; }

        /// <summary>
        /// Początek zmiany służy do obliczeenia wydajności maszyny od początku zmiany nr 1, 2, 3
        /// </summary>
        public DateTime PoczatekZmiany { get; set; }

        #endregion

        //dane z arduino
        String arduinoMessage;
        int licznikSztuk;
        private List<string> COMports;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            //MaxOdstep = Int32.Parse(ConfigurationManager.AppSettings["czasOczekiwania"]);
            MaxOdstep = Int32.Parse(Properties.Settings.Default.czasOczekiwania);
            //ArduinoPort = ConfigurationManager.AppSettings["arduinoPort"];
            LiniaProdukcyjna = Properties.Settings.Default.nazwaLiniiProdukcyjnej;
            this.Text = "Licznik czasu pracy maszyny v" + Application.ProductVersion;
            COMports = new List<string>();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: Ten wiersz kodu wczytuje dane do tabeli 'licznikDataSet.TypZdarzenias' . Możesz go przenieść lub usunąć.
            //this.typZdarzeniasTableAdapter.Fill(this.licznikDataSet.TypZdarzenias);
            //// TODO: Ten wiersz kodu wczytuje dane do tabeli 'licznikDataSet.Stan' . Możesz go przenieść lub usunąć.
            //this.stanTableAdapter.Fill(this.licznikDataSet.Stan);
            //// TODO: Ten wiersz kodu wczytuje dane do tabeli 'licznikDataSet.TypZdarzenias' . Możesz go przenieść lub usunąć.
            //this.typZdarzeniasTableAdapter.Fill(this.licznikDataSet.TypZdarzenias);
            PopulateCmbStan();
            PopulateDgvListaZdarzen();

            /*
            Po uruchomieniu formularza ustawiam stan "Czekam".
            Stan zmienia się na produkcja po odczycie z czytnika
            Stan może zmienić operator na dowolnie wybrany ręcznie
            Stan produkcja zostanie ustawiony automatycznie po odczycie z czytnika            
            */

            //arduino.PortName = ArduinoPort;
            SprawdzPolaczenieZArduino();
            btnZmienStan.Enabled = false;
            cmbStan.SelectedIndex = -1;
            cmbStan.Enabled = true;
            UpdateStateLabels("Czekam", DateTime.Now, 0);
            licznikSztuk = 0;

        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            SprawdzPolaczenieZArduino();



            // interwał = 1 sekunda
            CzasTrwania++;
            Odstep++;
            lblCzasTrwania.Text = CzasTrwania.ToString() + " sekund temu!";

            if (Odstep > MaxOdstep && ObecnyStan.NazwaZdarzenia == "Produkcja")
            {
                var typDoUstawienia = db.TypZdarzenia.Where(t => t.NazwaZdarzenia == "Nieokreślony").FirstOrDefault();
                UstawStan(typDoUstawienia);
            }
            else if (Odstep <= MaxOdstep && ObecnyStan.NazwaZdarzenia != "Produkcja")
            {
                var typDoUstawienia = db.TypZdarzenia.Where(t => t.NazwaZdarzenia == "Produkcja").FirstOrDefault();
                UstawStan(typDoUstawienia);
            }
        }

        private void SprawdzPolaczenieZArduino()
        {
            
            String[] porty = System.IO.Ports.SerialPort.GetPortNames();
            string myPort;
            

            if (arduino.IsOpen)
            {
                toolStripStatusLabel2.Text = "Połączenie z arduino: OK";

            }
            else
            {
                toolStripStatusLabel2.Text = "Połączenie z arduino: Brak";
                foreach (var item in porty)
                {
                    myPort = item;
                    try
                    {
                        arduino.PortName = myPort;
                        arduino.Open();
                    }
                    catch (Exception)
                    {

                        toolStripStatusLabel2.Text = "Połączenie z arduino: Brak";
                    }
                    
                }
            }
        }



        private void PopulateCmbStan()
        {
            List<TypZdarzenia> listaTypowZdarzen = db.TypZdarzenia.ToList();
            cmbStan.DataSource = listaTypowZdarzen;
            cmbStan.DisplayMember = "NazwaZdarzenia";
            cmbStan.ValueMember = "TypZdarzeniaId";
        }

        private void PopulateDgvListaZdarzen()
        {
            List<Stan> listaStanow = db.Stan.Take(500).Where(s => s.LiniaProdukcyjna == LiniaProdukcyjna).ToList();
            var lista = listaStanow.Select(l => new { l.StanId, l.TypZdarzenia.NazwaZdarzenia, l.GodzinaUruchomienia, l.CzasTrwania, l.Brygada }).OrderByDescending(l => l.GodzinaUruchomienia).ToList();
            dgvListaZdarzen.DataSource = lista;
        }


        private void btnZmienStan_Click(object sender, EventArgs e)
        {
            var typDoUstawienia = db.TypZdarzenia.Where(t => t.TypZdarzeniaId == (int)cmbStan.SelectedValue).FirstOrDefault();
            //using (LicznikDataModel db = new LicznikDataModel())

            UstawStan(typDoUstawienia);
        }




        private void cmbStan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStan.SelectedIndex != -1)
            {
                btnZmienStan.Enabled = true;
            }

        }

        private void UpdateStateLabels(string obecnyStan, DateTime czasUruchomienia, int licznik)
        {
            lblOpis.Text = obecnyStan;
            lblUruchomionoo.Text = czasUruchomienia.ToString();
            lblCzasTrwania.Text = licznik.ToString();
        }

        

        private void btnStartMaszyny_Click(object sender, EventArgs e)
        {
            /**
            Uruchomienie programu
            1. Sprawdzam czy formularz został wypełniony
            2. Użytkownik wybiera stan początkowy
            3. Uruchamiam arduino
            4. Startuję licznik
            */
            // Uruchamiam formularz inicjujący

            if (rdbBrygada1.Checked == false && rdbBrygada2.Checked == false && rdbBrygada3.Checked == false)
            {
                errorProvider1.SetError(grBoxBrygada, "Proszę wybrać numer brygady!");
            }
            else if (cmbStan.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbStan, "Proszę wybrać stan.");
            }
            else
            {
                // formularz został wypełniony więc mogę uruchomić licznik
                errorProvider1.SetError(grBoxBrygada, "");
                errorProvider1.SetError(cmbStan, "");

                // sprawdzam która brygada została wybrana i ustawiam właściwość Brygada
                if (rdbBrygada1.Checked == true)
                {
                    Brygada = 1;
                }
                else if (rdbBrygada2.Checked == true)
                {
                    Brygada = 2;
                }
                else
                {
                    Brygada = 3;
                }

                // ustawienia nasłuchiwania
                try
                {
                    SprawdzPolaczenieZArduino();
                    CzasTrwania = 0;

                    ObecnyStan = db.TypZdarzenia.Where(t => t.TypZdarzeniaId == (int)cmbStan.SelectedValue).FirstOrDefault();
                    CzasUruchomienia = DateTime.Now;
                    UpdateStateLabels(ObecnyStan.NazwaZdarzenia, CzasUruchomienia, CzasTrwania);

                    // udostępniam narzędzia do zmiany stanu
                    cmbStan.Enabled = true;
                    cmbStan.SelectedIndex = -1;

                    //Wyłączam przycisk start
                    btnStartMaszyny.Enabled = false;
                    timer1.Start();
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Brak połączenia z czujnikiem:\n1. Odłącz kabel usb.\n2. Podłącz go ponownie.\n\nJeżeli powyższe kroki nie rozwiążą problemu, skontaktuj się z autorem programu.",
                        "Brak połączenia z arduino!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie można uruchomić programu\nSkontaktuj się z autorem programu. " + ex.ToString());
                }

            }
        }


        /// <summary>
        /// Ustawia stan obecny maszyny
        /// </summary>
        /// <param name="stan">Nowy stan maszyny</param>
        private void UstawStan(TypZdarzenia nowyStan)
        {
            if (ObecnyStan != null)
            {

                if (ObecnyStan.NazwaZdarzenia == "Nieokreślony" && nowyStan.NazwaZdarzenia != "Produkcja")
                {
                    // jeżeli ObecnyStan to "Nieokreślony" a nowyStan to nie "Produkcja" zmieniamy Obecny stan bez zapisywania w bazie.
                    ObecnyStan = nowyStan;
                    UpdateStateLabels(ObecnyStan.NazwaZdarzenia, CzasUruchomienia, CzasTrwania);
                    cmbStan.SelectedIndex = -1;
                    btnZmienStan.Enabled = false;
                }
                else if (ObecnyStan.NazwaZdarzenia == "Awaria")
                {
                    // typ ObecnyStan do zapisania to awaria zapisujemy obiekt awarii
                    Awaria nowaAwaria = new Awaria { GodzinaUruchomienia = CzasUruchomienia, CzasTrwania = this.CzasTrwania, TypZdarzenia = ObecnyStan, Brygada = this.Brygada, LiniaProdukcyjna = this.LiniaProdukcyjna };
                    db.Awaria.Add(nowaAwaria);
                    db.SaveChanges();
                    PopulateDgvListaZdarzen();
                    // ustawiam nowy stan obecny
                    DateTime godz = DateTime.Now;
                    ObecnyStan = nowyStan;
                    CzasUruchomienia = DateTime.Now;
                    UpdateStateLabels(ObecnyStan.NazwaZdarzenia, CzasUruchomienia, CzasTrwania);

                    // zerowanie stanu formularza
                    CzasTrwania = 0;
                    cmbStan.SelectedIndex = -1;
                    btnZmienStan.Enabled = false;
                }
                else if (ObecnyStan.NazwaZdarzenia == "Przezbrojenie")
                {
                    // typ ObecnyStan to Przezbrojenie zapisujemy obiekt przezbrojenie
                    Przezbrojenie nowePrzezbrojenie = new Przezbrojenie { GodzinaUruchomienia = CzasUruchomienia, CzasTrwania = this.CzasTrwania, TypZdarzenia = ObecnyStan, Brygada = this.Brygada, LiniaProdukcyjna = this.LiniaProdukcyjna };
                    db.Przezbrojenia.Add(nowePrzezbrojenie);
                    db.SaveChanges();
                    PopulateDgvListaZdarzen();
                    // ustawiam nowy stan obecny
                    DateTime godz = DateTime.Now;
                    ObecnyStan = nowyStan;
                    CzasUruchomienia = DateTime.Now;
                    UpdateStateLabels(ObecnyStan.NazwaZdarzenia, CzasUruchomienia, CzasTrwania);

                    // zerowanie stanu formularza
                    CzasTrwania = 0;
                    cmbStan.SelectedIndex = -1;
                    btnZmienStan.Enabled = false;
                }
                else
                {
                    // zapisujemy stan obecny
                    Stan stanDoZapisania = new Stan { GodzinaUruchomienia = CzasUruchomienia, CzasTrwania = this.CzasTrwania, TypZdarzenia = ObecnyStan, Brygada = this.Brygada, LiniaProdukcyjna = this.LiniaProdukcyjna };
                    db.Stan.Add(stanDoZapisania);
                    db.SaveChanges();
                    PopulateDgvListaZdarzen();
                    // ustawiam nowy stan obecny
                    DateTime godz = DateTime.Now;
                    ObecnyStan = nowyStan;
                    CzasUruchomienia = DateTime.Now;
                    UpdateStateLabels(ObecnyStan.NazwaZdarzenia, CzasUruchomienia, CzasTrwania);

                    // zerowanie stanu formularza
                    CzasTrwania = 0;
                    cmbStan.SelectedIndex = -1;
                    btnZmienStan.Enabled = false;
                }
            }

        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // po kliknięciu wiersza otwieramy okno edycji
            int stanID = (int)dgvListaZdarzen.Rows[e.RowIndex].Cells[stanIdDataGridViewColumn.Name].Value;
            //MessageBox.Show(stanID.ToString());

            using (LicznikDataModel db = new LicznikDataModel())
            {
                //ustalam typ zdarzenia
                var typ = (from s in db.Stan
                           where s.StanId == stanID
                           select s).FirstOrDefault();


                if (typ.TypZdarzenia.NazwaZdarzenia == "Awaria")
                {
                    Awaria aw = (Awaria)typ;
                    OpisAwariiForm opisAwarii = new OpisAwariiForm { WybranaAwaria = aw };
                    opisAwarii.ShowDialog();
                }
                else if (typ.TypZdarzenia.NazwaZdarzenia == "Przezbrojenie")
                {
                    Przezbrojenie przezbr = (Przezbrojenie)typ;
                    DanePrzezbrojeniaForm danePrzezbrojenia = new DanePrzezbrojeniaForm { WybranePrzezbrojenie = przezbr };
                    DialogResult wynik = danePrzezbrojenia.ShowDialog();
                    if (wynik == DialogResult.OK)
                    {
                        przezbr = danePrzezbrojenia.WybranePrzezbrojenie;
                        db.Entry(przezbr).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Z tym typem awarii nie jest związane żadne działanie.");
                }
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            // odczyt danych z arduino
            try
            {
                arduinoMessage = sp.ReadLine();
                if (arduinoMessage == "1\r")
                {
                    this.BeginInvoke(new EventHandler(czytajImpuls));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się odczytać wartośći impulsu z urządzenia! #arduino_DataReceived()" + ex.ToString());
            }
        }

        private void czytajImpuls(object sender, EventArgs e)
        {
            licznikSztuk++;
            lblBiezacyCzasCyklu.Text = Odstep.ToString();

            try
            {
                Tempo = 60F / Odstep;
            }
            catch (DivideByZeroException ex)
            {

                Tempo = 0.0F;
            }

            lblIloscCykliNaMinute.Text = string.Format("{0:0.0}", Tempo) + " cykli/minutę";
            Odstep = 0;
            lblLicznikSztuk.Text = licznikSztuk.ToString();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Zapisuję ostatni stan.
            if (ObecnyStan != null)
            {
                if (ObecnyStan.NazwaZdarzenia == "Awaria")
                {
                    Awaria nowaAwaria = new Awaria { GodzinaUruchomienia = CzasUruchomienia, CzasTrwania = this.CzasTrwania, TypZdarzenia = ObecnyStan, Brygada = this.Brygada, LiniaProdukcyjna = this.LiniaProdukcyjna };
                    db.Awaria.Add(nowaAwaria);
                    db.SaveChanges();
                }
                else if (ObecnyStan.NazwaZdarzenia == "Przezbrojenie")
                {
                    Przezbrojenie nowePrzezbrojenie = new Przezbrojenie { GodzinaUruchomienia = CzasUruchomienia, CzasTrwania = this.CzasTrwania, TypZdarzenia = ObecnyStan, Brygada = this.Brygada, LiniaProdukcyjna = this.LiniaProdukcyjna };
                    db.Przezbrojenia.Add(nowePrzezbrojenie);
                    db.SaveChanges();
                }
                else
                {
                    Stan stanDoZapisania = new Stan { GodzinaUruchomienia = CzasUruchomienia, CzasTrwania = this.CzasTrwania, TypZdarzenia = ObecnyStan, Brygada = this.Brygada, LiniaProdukcyjna = this.LiniaProdukcyjna };
                    db.Stan.Add(stanDoZapisania);
                    db.SaveChanges();
                }
            }
            //zamykam połączenie arduino
            this.closeArduinoConnection();
        }


        /// <summary>
        /// Zamyka połączenie z arduino. wywoływane jest w formClosing
        /// </summary>
        private void closeArduinoConnection()
        {
            if (arduino != null)
            {
                try
                {
                    if (arduino.IsOpen == true)
                    {
                        arduino.DiscardInBuffer();
                        arduino.DiscardOutBuffer();
                        arduino.Close();
                    }
                }
                catch (Exception ex)
                {

                }
                if (arduino != null)
                {
                    arduino.Dispose();
                }
            }
        }

        private void dodajTypZdarzeniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajTypZdarzeniaForm typForm = new DodajTypZdarzeniaForm();

            DialogResult wynik = typForm.ShowDialog();
            if (wynik == DialogResult.OK)
            {
                //this.typZdarzeniasTableAdapter.Fill(this.licznikDataSet.TypZdarzenias);
                PopulateCmbStan();
                cmbStan.SelectedIndex = -1;
            }
        }

        private void generujRaportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerujRaportForm nowyRaport = new GenerujRaportForm();
            nowyRaport.ShowDialog();
        }

        private void rdbBrygada_CheckedChanged(object sender, EventArgs e)
        {
            // sprawdzam która brygada została wybrana i ustawiam właściwość Brygada
            if (rdbBrygada1.Checked == true)
            {
                Brygada = 1;
            }
            else if (rdbBrygada2.Checked == true)
            {
                Brygada = 2;
            }
            else
            {
                Brygada = 3;
            }
        }

        private void dodajMaszynyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajMaszynyForm nowaMaszyna = new DodajMaszynyForm();
            nowaMaszyna.ShowDialog();
        }




        //funkcje testowe symulator sztuk
        // TODO: usunąć
        //private void btnStart_Click(object sender, EventArgs e)
        //{

        //    timer2.Interval = (int)nudPrzerwa.Value * 1000;
        //    timer2.Start();
        //}

        //private void timer2_Tick(object sender, EventArgs e)
        //{
        //    Odstep = 0;
        //}

        //private void nudPrzerwa_ValueChanged(object sender, EventArgs e)
        //{
        //    timer2.Interval = (int)nudPrzerwa.Value * 1000;
        //}

        //private void btnStop_Click(object sender, EventArgs e)
        //{
        //    timer2.Stop();
        //}
        // Koniec symulatora

    }
}
