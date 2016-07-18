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
    public partial class DodajProdukt : Form
    {

        public DodajProdukt()
        {
            InitializeComponent();
        }

        private void DodajProdukt_Load(object sender, EventArgs e)
        {

        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnZapisz_Click(object sender, EventArgs e)
        {
            if (ValidujFormularz())
            {
                using (var db = new LicznikDataModel())
                {
                    Produkt nowyProdukt = new Produkt { NazwaProduktu = txtNazwaProduktu.Text, NazwaElementu = txtNazwaElementu.Text };
                    db.Produkt.Add(nowyProdukt);
                    try
                    {
                        await db.SaveChangesAsync();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException)
                    {
                        MessageBox.Show("Próbujesz dodać produkt, który już istnieje w bazie danych.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.Abort;
                        this.Close();
                    }
                }

            }
        }

        private bool ValidujFormularz()
        {
            if (String.IsNullOrEmpty(txtNazwaProduktu.Text))
            {
                errorProvider1.SetError(txtNazwaProduktu, "To pole musi być wypełnione");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtNazwaProduktu, "");
            }


            if (string.IsNullOrEmpty(txtNazwaElementu.Text))
            {
                errorProvider1.SetError(txtNazwaElementu, "To pole musi być wypełnione");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtNazwaElementu, "");

            }
            return true;
        }


    }
}
