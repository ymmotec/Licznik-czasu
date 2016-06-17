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
        private LicznikDataModel db;
        private Linia linia;
        private List<TypZdarzenia> listaTypowDoDodania;

        public DodajTypZdarzeniaForm()
        {
            InitializeComponent();
            db = new LicznikDataModel();
            listaTypowDoDodania = db.TypZdarzenia.ToList();
        }



        private void DodajTypZdarzeniaForm_Load(object sender, EventArgs e)
        {
            PopulateCmbTypDoDodania();
            PopulatedgvListaTypowZdarzen();
        }

        private void PopulateCmbTypDoDodania()
        {
            cmbTypDoDodania.DataSource = listaTypowDoDodania;
            cmbTypDoDodania.DisplayMember = "NazwaZdarzenia";
            cmbTypDoDodania.ValueMember = "TypZdarzeniaId";
            cmbTypDoDodania.SelectedIndex = -1;
        }

        private void PopulatedgvListaTypowZdarzen()
        {
            linia = db.Linia.Where(l => l.NazwaLinii == Properties.Settings.Default.nazwaLiniiProdukcyjnej).FirstOrDefault();
            List<TypZdarzenia> lista = linia.TypyZdarzen.ToList();
            dgvListaTypowZdarzen.DataSource = lista;
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cmbTypDoDodania.SelectedIndex == -1)
            {
                if (!String.IsNullOrEmpty(cmbTypDoDodania.Text))
                {
                    TypZdarzenia nowyTyp = new TypZdarzenia { NazwaZdarzenia = cmbTypDoDodania.Text.ToString() };

                    db.Linia.FirstOrDefault(l => l.LiniaId == linia.LiniaId).TypyZdarzen.Add(nowyTyp);
                    db.SaveChanges();

                    PopulatedgvListaTypowZdarzen();
                    PopulateCmbTypDoDodania();
                    this.cmbTypDoDodania.Text = "";
                }
            }
            else
            {
                TypZdarzenia wybranyTyp = db.TypZdarzenia.Where(t => t.TypZdarzeniaId == (int)cmbTypDoDodania.SelectedValue).FirstOrDefault();
                if (!wybranyTyp.Linie.Contains(linia))
                {
                    db.Linia.FirstOrDefault(l => l.LiniaId == linia.LiniaId).TypyZdarzen.Add(wybranyTyp);
                    db.SaveChanges();
                    PopulatedgvListaTypowZdarzen();
                    PopulateCmbTypDoDodania();
                    cmbTypDoDodania.SelectedIndex = -1;
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
