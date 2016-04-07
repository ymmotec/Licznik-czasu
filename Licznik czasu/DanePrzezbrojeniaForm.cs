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
        public Przezbrojenie WybranePrzezbrojenie { get; set; }
        public DanePrzezbrojeniaForm()
        {
            InitializeComponent();
        }

        private void DanePrzezbrojeniaForm_Load(object sender, EventArgs e)
        {
            txtOpisPrzezbrojenia.Text = WybranePrzezbrojenie.OpisPrzezbrojenia;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            WybranePrzezbrojenie.OpisPrzezbrojenia = txtOpisPrzezbrojenia.Text;
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
