using OEE.Data.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OEE.Data;
using System.IO;

namespace OEE.Raport
{
    public partial class Form1 : Form
    {
        public DateTime DataPoczatkowa { get; set; }

        public DateTime DataKoncowa { get; set; }

        public Linia Linia { get; set; }

        private List<Stan> raport;

        private LicznikDataModel db;



        public Form1()
        {

            InitializeComponent();
            ustawDaty();
            this.db = new LicznikDataModel();
            this.populateLstLinia();
        }

        #region Ustawienia dat formularza

        private void dtpDataPoczatkowa_ValueChanged(object sender, EventArgs e)
        {
            ustawDaty();
        }

        private void dtpDataKoncowa_ValueChanged(object sender, EventArgs e)
        {
            ustawDaty();
        }



        private void ustawDaty()
        {

            this.DataPoczatkowa = new DateTime(dtpDataPoczatkowa.Value.Year,
                dtpDataPoczatkowa.Value.Month,
                dtpDataPoczatkowa.Value.Day,
                (int)nudGodzinaPoczatkowa.Value,
                (int)nudMinutyPoczatkowe.Value, 0);

            this.DataKoncowa = new DateTime(dtpDataKoncowa.Value.Year,
                dtpDataKoncowa.Value.Month,
                dtpDataKoncowa.Value.Day,
                (int)nudGodzinaKoncowa.Value,
                (int)nudMinutyKoncowe.Value, 0);
            sprawdzPoprawnoscDat();
        }

        private void sprawdzPoprawnoscDat()
        {
            if (this.DataPoczatkowa > this.DataKoncowa)
            {
                errorProvider1.SetError(dtpDataPoczatkowa, "Data początkowa nie może być późniejsza od daty końcowej!");
                //btnZapisz.Enabled = false;
                btnSzukaj.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(dtpDataPoczatkowa, "");
                btnSzukaj.Enabled = true;
                //btnZapisz.Enabled = true;
            }
        }

        private void nudGodzinaPoczatkowa_ValueChanged(object sender, EventArgs e)
        {
            ustawDaty();
        }

        private void nudMinutyPoczatkowe_ValueChanged(object sender, EventArgs e)
        {
            ustawDaty();
        }

        private void nudGodzinaKoncowa_ValueChanged(object sender, EventArgs e)
        {
            ustawDaty();
        }

        private void nudMinutyKoncowe_ValueChanged(object sender, EventArgs e)
        {
            ustawDaty();
        }

        #endregion


        private void btnZapisz_Click(object sender, EventArgs e)
        {
            RaportGenerator raportGenerator = new RaportGenerator(raport);
            StringBuilder csvData = raportGenerator.getCSVData();

            //Zapis danych na dysku
            string fileName = DateTime.Now.ToShortDateString();
            string myFullPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + fileName + ".csv";
            using (StreamWriter outputFile = new StreamWriter(myFullPath, false, Encoding.GetEncoding("Windows-1250")))
            {
                outputFile.Write(csvData);
            }
            MessageBox.Show("Dane zostały zapisane w pliku \n" + myFullPath, "Dane zostały zapisane.");
            
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            if (this.Linia == null)
                raport = db.Stan.Where(r => r.GodzinaUruchomienia > DataPoczatkowa && r.GodzinaUruchomienia < DataKoncowa).ToList();
            else
                raport = db.Stan.Where(r => r.GodzinaUruchomienia > DataPoczatkowa && r.GodzinaUruchomienia < DataKoncowa && r.LiniaProdukcyjna == this.Linia.NazwaLinii).ToList();

            populateTheGridView();
            btnZapisz.Enabled = true;
        }

        private void populateTheGridView()
        {
            var lista = raport.Select(l => new { l.LiniaProdukcyjna, l.TypZdarzenia.NazwaZdarzenia, l.Brygada, l.GodzinaUruchomienia, l.CzasTrwania }).ToList();
            //this.dataGridView1.DataSource = raport;
            this.dataGridView1.DataSource = lista;
        }

        private void populateLstLinia()
        {
            List<Linia> linia = db.Linia.ToList();

            lstLinia.DataSource = linia;
            lstLinia.DisplayMember = "NazwaLinii";
            lstLinia.ValueMember = "LiniaId";
        }

        private void ckbCzyWszystkie_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCzyWszystkie.Checked == false)
            {
                lstLinia.Enabled = true;
                lstLinia.SelectedIndex = 0;
            }
            else
            {
                lstLinia.Enabled = false;
                lstLinia.SelectedIndex = -1;
            }
        }

        private void lstLinia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ckbCzyWszystkie.Checked == true)
            {
                this.Linia = null;
                lstLinia.Enabled = false;
                lstLinia.SelectedIndex = -1;
            }
            else
            {
                this.Linia = db.Linia.Where(l => l.LiniaId == (int)lstLinia.SelectedValue).FirstOrDefault();
            }
        }

       
    }
}
