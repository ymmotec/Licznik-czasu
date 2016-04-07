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
    public partial class DodajMaszynyForm : Form
    {

        private LicznikDataModel db = new LicznikDataModel();

        public DodajMaszynyForm()
        {
            InitializeComponent();
        }

        private void DodajMaszynyForm_Load(object sender, EventArgs e)
        {
            PopulateMaszynyGrid();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNowaMaszyna.Text != null)
            {
                using (var db = new LicznikDataModel())
                {
                    Linia linia = db.Linia.Where(n => n.NazwaLinii == Properties.Settings.Default.nazwaLiniiProdukcyjnej).FirstOrDefault();
                    Maszyny nowaMaszyna = new Maszyny { NazwaMaszyny = txtNowaMaszyna.Text.ToString() };
                    linia.Maszyny.Add(nowaMaszyna);
                    db.SaveChanges();
                    PopulateMaszynyGrid();
                    this.txtNowaMaszyna.Text = "";
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PopulateMaszynyGrid()
        {
            var maszyny = db.Maszyna.Where(m => m.Linia.NazwaLinii == Properties.Settings.Default.nazwaLiniiProdukcyjnej).Select(s => new { s.MaszynaId, s.NazwaMaszyny }).ToList();
            dataGridView1.DataSource = maszyny;
        }

    }
}
