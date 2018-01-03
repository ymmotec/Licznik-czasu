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
    public partial class DanePrzezbrojeniaForm : Form
    {
        public Produkt ObecnyProdukt { get; set; }
        public Kolor ObecnyKolor { get; set; }
        
        public DanePrzezbrojeniaForm()
        {
            InitializeComponent();
        }

        private void DanePrzezbrojeniaForm_Load(object sender, EventArgs e)
        {
            PopulateCmbProdukt();
            PopulateCmbKolor();
            
        }

        private void PopulateCmbKolor()
        {
            using (var db = new LicznikDataModel())
            {
                var listaKolorow = db.Kolor.ToList();
                cmbKolor.DataSource = listaKolorow;
                cmbKolor.ValueMember = "KolorId";
                cmbKolor.DisplayMember = "NazwaKoloru";
            }
        }

        private void PopulateCmbProdukt()
        {
            using (var db = new LicznikDataModel())
            {
                var listaProduktow = db.Produkt.ToList();
                cmbProdukt.DataSource = listaProduktow;
                cmbProdukt.ValueMember = "ProduktId";
                cmbProdukt.DisplayMember = "PelnaNazwa";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new LicznikDataModel())
            {
                ObecnyProdukt = db.Produkt.Where(p => p.ProduktId == (int)cmbProdukt.SelectedValue).FirstOrDefault();
                ObecnyKolor = db.Kolor.Where(k => k.KolorId == (int)cmbKolor.SelectedValue).FirstOrDefault();
            }
            ///////////////////
           
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}
