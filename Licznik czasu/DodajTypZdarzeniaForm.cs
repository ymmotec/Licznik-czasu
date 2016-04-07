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

namespace Licznik_czasu
{
    public partial class DodajTypZdarzeniaForm : Form
    {
        public DodajTypZdarzeniaForm()
        {
            InitializeComponent();
        }

        private void DodajTypZdarzeniaForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'licznikDataSet.TypZdarzenias' . Możesz go przenieść lub usunąć.
            this.typZdarzeniasTableAdapter.Fill(this.licznikDataSet.TypZdarzenias);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using(var db = new LicznikDataModel())
            {
                if (txtNowyTypZdarzenia.Text != "")
                {
                    TypZdarzenia nowyTyp = new TypZdarzenia { NazwaZdarzenia = txtNowyTypZdarzenia.Text.ToString() };
                    db.TypZdarzenia.Add(nowyTyp);
                    db.SaveChanges();
                    this.typZdarzeniasTableAdapter.Fill(this.licznikDataSet.TypZdarzenias);
                    this.txtNowyTypZdarzenia.Text = "";
                }
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
