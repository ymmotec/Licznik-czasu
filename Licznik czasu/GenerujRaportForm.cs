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
using System.IO;

namespace Licznik_czasu
{
    public partial class GenerujRaportForm : Form
    {
        StringBuilder data = new StringBuilder();
        string myPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);




        public GenerujRaportForm()
        {
            InitializeComponent();


        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            long fileName = DateTime.Now.ToBinary();
            string myFullPath = myPath + "\\" + fileName.ToString() + ".csv";
            if (dtpStartDate.Value.Day != dtpEndDate.Value.Day)
            {
                using (var db = new LicznikDataModel())
                {
                    List<Stan> raport = db.Stan.Where(r => r.GodzinaUruchomienia > dtpStartDate.Value && r.GodzinaUruchomienia < dtpEndDate.Value).ToList();
                    data.Append("Linia produkcyjna,");
                    data.Append("Typ Zdarzenia,");
                    data.Append("Godzina uruchomienia,");
                    data.Append("Czas trwania,");
                    data.Append("Brygada,");
                    data.Append("Opis Awarii,");
                    data.Append("Maszyna,");
                    data.Append("Opis przezbrojenia,");
                    data.Append("\n");

                    foreach (var item in raport)
                    {
                        data.Append(item.LiniaProdukcyjna);
                        data.Append(",");
                        data.Append(item.TypZdarzenia.NazwaZdarzenia);
                        data.Append(",");
                        data.Append(item.GodzinaUruchomienia.ToString());
                        data.Append(",");
                        data.Append(item.CzasTrwania.ToString());
                        data.Append(",");
                        data.Append(item.Brygada.ToString());
                        data.Append(",");
                        if (item.TypZdarzenia.NazwaZdarzenia == "Awaria")
                        {
                            Awaria aw = (Awaria)item;
                            data.Append(aw.OpisAwarii);
                            data.Append(",");
                            if (aw.Maszyna != null)
                            {
                                data.Append(aw.Maszyna.NazwaMaszyny);
                            }
                            else
                            {
                                data.Append("Nie określono miejsca awarii");
                            }

                            data.Append(",");
                        }
                        else if (item.TypZdarzenia.NazwaZdarzenia == "Przezbrojenie")
                        {
                            Przezbrojenie pr = (Przezbrojenie)item;
                            data.Append(pr.OpisPrzezbrojenia);
                            data.Append(",");
                        }



                        data.Append("\n");
                    }

                    using (StreamWriter outputFile = new StreamWriter(myFullPath, false, Encoding.GetEncoding("Windows-1250")))
                    {
                        outputFile.Write(data);
                    }
                    MessageBox.Show("Dane zostały zapisane w pliku \n" + myFullPath, "Dane zostały zapisane.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Wybrałeś takie same daty!", "Uwaga");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
