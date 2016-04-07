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
using System.Data.Entity.Validation;

namespace Licznik_czasu
{
    public partial class OpisAwariiForm : Form
    {
        // właściwości
        public Awaria WybranaAwaria { get; set; }
        LicznikDataModel db = new LicznikDataModel();


        public OpisAwariiForm()
        {
            InitializeComponent();
        }

        private void OpisAwariiForm_Load(object sender, EventArgs e)
        {

            populateCmbMaszyny();

            txtOpis.Text = WybranaAwaria.OpisAwarii;
            if (WybranaAwaria.Maszyna == null)
            {
                cmbMaszyny.SelectedIndex = -1;
            }
            else
            {
                cmbMaszyny.SelectedValue = WybranaAwaria.Maszyna.MaszynaId;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new LicznikDataModel())
            {
                Awaria aw = db.Awaria.Where(a => a.StanId == WybranaAwaria.StanId).FirstOrDefault();
                aw.Maszyna = db.Maszyna.Where(m => m.MaszynaId == (int)cmbMaszyny.SelectedValue).FirstOrDefault();
                aw.OpisAwarii = txtOpis.Text;
                aw.TypZdarzenia = db.TypZdarzenia.Where(t => t.TypZdarzeniaId == WybranaAwaria.TypZdarzenia.TypZdarzeniaId).FirstOrDefault();
                db.SaveChanges();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDodajNowaMaszyne_Click(object sender, EventArgs e)
        {
            DodajMaszynyForm dodajMaszyny = new DodajMaszynyForm();
            dodajMaszyny.ShowDialog();
            DialogResult wynik = dodajMaszyny.DialogResult;
            if (wynik == DialogResult.OK)
            {
                populateCmbMaszyny();
            }
        }

        private void populateCmbMaszyny()
        {
            var maszyny = db.Maszyna.Where(m => m.Linia.NazwaLinii == Properties.Settings.Default.nazwaLiniiProdukcyjnej).ToList();
            cmbMaszyny.DataSource = db.Maszyna.ToList();
            cmbMaszyny.DisplayMember = "NazwaMaszyny";
            cmbMaszyny.ValueMember = "MaszynaId";
            cmbMaszyny.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection kolekcjaDoAutocomplete = new AutoCompleteStringCollection();
            kolekcjaDoAutocomplete.AddRange(maszyny.Select(a => a.NazwaMaszyny).ToArray());

            cmbMaszyny.AutoCompleteCustomSource = kolekcjaDoAutocomplete;
        }
    }
}
