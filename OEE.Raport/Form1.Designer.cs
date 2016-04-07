namespace OEE.Raport
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstLinia = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiniaProdukcyjna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypZdarzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brygada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodzinaUruchomienia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzasTrwania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDataPoczatkowa = new System.Windows.Forms.DateTimePicker();
            this.dtpDataKoncowa = new System.Windows.Forms.DateTimePicker();
            this.ckbCzyWszystkie = new System.Windows.Forms.CheckBox();
            this.nudGodzinaPoczatkowa = new System.Windows.Forms.NumericUpDown();
            this.nudMinutyPoczatkowe = new System.Windows.Forms.NumericUpDown();
            this.nudGodzinaKoncowa = new System.Windows.Forms.NumericUpDown();
            this.nudMinutyKoncowe = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnZapisz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGodzinaPoczatkowa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutyPoczatkowe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGodzinaKoncowa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutyKoncowe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLinia
            // 
            this.lstLinia.Enabled = false;
            this.lstLinia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstLinia.FormattingEnabled = true;
            this.lstLinia.ItemHeight = 20;
            this.lstLinia.Location = new System.Drawing.Point(37, 53);
            this.lstLinia.Name = "lstLinia";
            this.lstLinia.Size = new System.Drawing.Size(120, 184);
            this.lstLinia.TabIndex = 0;
            this.lstLinia.SelectedIndexChanged += new System.EventHandler(this.lstLinia_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StanId,
            this.LiniaProdukcyjna,
            this.TypZdarzenia,
            this.Brygada,
            this.GodzinaUruchomienia,
            this.CzasTrwania});
            this.dataGridView1.Location = new System.Drawing.Point(12, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 329);
            this.dataGridView1.TabIndex = 1;
            // 
            // StanId
            // 
            this.StanId.DataPropertyName = "StanId";
            this.StanId.HeaderText = "Stan ID";
            this.StanId.Name = "StanId";
            this.StanId.ReadOnly = true;
            this.StanId.Visible = false;
            // 
            // LiniaProdukcyjna
            // 
            this.LiniaProdukcyjna.DataPropertyName = "LiniaProdukcyjna";
            this.LiniaProdukcyjna.HeaderText = "Linia Produkcyjna";
            this.LiniaProdukcyjna.Name = "LiniaProdukcyjna";
            this.LiniaProdukcyjna.ReadOnly = true;
            // 
            // TypZdarzenia
            // 
            this.TypZdarzenia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypZdarzenia.DataPropertyName = "NazwaZdarzenia";
            this.TypZdarzenia.HeaderText = "Typ zdarzenia";
            this.TypZdarzenia.Name = "TypZdarzenia";
            this.TypZdarzenia.ReadOnly = true;
            // 
            // Brygada
            // 
            this.Brygada.DataPropertyName = "Brygada";
            this.Brygada.HeaderText = "Brygada";
            this.Brygada.Name = "Brygada";
            this.Brygada.ReadOnly = true;
            // 
            // GodzinaUruchomienia
            // 
            this.GodzinaUruchomienia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GodzinaUruchomienia.DataPropertyName = "GodzinaUruchomienia";
            this.GodzinaUruchomienia.HeaderText = "Godzina uruchomienia";
            this.GodzinaUruchomienia.Name = "GodzinaUruchomienia";
            this.GodzinaUruchomienia.ReadOnly = true;
            // 
            // CzasTrwania
            // 
            this.CzasTrwania.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CzasTrwania.DataPropertyName = "CzasTrwania";
            this.CzasTrwania.HeaderText = "Czas trwania";
            this.CzasTrwania.Name = "CzasTrwania";
            this.CzasTrwania.ReadOnly = true;
            // 
            // dtpDataPoczatkowa
            // 
            this.dtpDataPoczatkowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDataPoczatkowa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPoczatkowa.Location = new System.Drawing.Point(176, 46);
            this.dtpDataPoczatkowa.Name = "dtpDataPoczatkowa";
            this.dtpDataPoczatkowa.Size = new System.Drawing.Size(125, 26);
            this.dtpDataPoczatkowa.TabIndex = 2;
            this.dtpDataPoczatkowa.ValueChanged += new System.EventHandler(this.dtpDataPoczatkowa_ValueChanged);
            // 
            // dtpDataKoncowa
            // 
            this.dtpDataKoncowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDataKoncowa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataKoncowa.Location = new System.Drawing.Point(176, 99);
            this.dtpDataKoncowa.Name = "dtpDataKoncowa";
            this.dtpDataKoncowa.Size = new System.Drawing.Size(125, 26);
            this.dtpDataKoncowa.TabIndex = 3;
            this.dtpDataKoncowa.ValueChanged += new System.EventHandler(this.dtpDataKoncowa_ValueChanged);
            // 
            // ckbCzyWszystkie
            // 
            this.ckbCzyWszystkie.AutoSize = true;
            this.ckbCzyWszystkie.Checked = true;
            this.ckbCzyWszystkie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbCzyWszystkie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ckbCzyWszystkie.Location = new System.Drawing.Point(37, 23);
            this.ckbCzyWszystkie.Name = "ckbCzyWszystkie";
            this.ckbCzyWszystkie.Size = new System.Drawing.Size(99, 24);
            this.ckbCzyWszystkie.TabIndex = 4;
            this.ckbCzyWszystkie.Text = "Wszystkie";
            this.ckbCzyWszystkie.UseVisualStyleBackColor = true;
            this.ckbCzyWszystkie.CheckedChanged += new System.EventHandler(this.ckbCzyWszystkie_CheckedChanged);
            // 
            // nudGodzinaPoczatkowa
            // 
            this.nudGodzinaPoczatkowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudGodzinaPoczatkowa.Location = new System.Drawing.Point(323, 48);
            this.nudGodzinaPoczatkowa.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudGodzinaPoczatkowa.Name = "nudGodzinaPoczatkowa";
            this.nudGodzinaPoczatkowa.Size = new System.Drawing.Size(63, 26);
            this.nudGodzinaPoczatkowa.TabIndex = 5;
            this.nudGodzinaPoczatkowa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudGodzinaPoczatkowa.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudGodzinaPoczatkowa.ValueChanged += new System.EventHandler(this.nudGodzinaPoczatkowa_ValueChanged);
            // 
            // nudMinutyPoczatkowe
            // 
            this.nudMinutyPoczatkowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudMinutyPoczatkowe.Location = new System.Drawing.Point(415, 49);
            this.nudMinutyPoczatkowe.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutyPoczatkowe.Name = "nudMinutyPoczatkowe";
            this.nudMinutyPoczatkowe.Size = new System.Drawing.Size(63, 26);
            this.nudMinutyPoczatkowe.TabIndex = 6;
            this.nudMinutyPoczatkowe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMinutyPoczatkowe.ValueChanged += new System.EventHandler(this.nudMinutyPoczatkowe_ValueChanged);
            // 
            // nudGodzinaKoncowa
            // 
            this.nudGodzinaKoncowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudGodzinaKoncowa.Location = new System.Drawing.Point(323, 101);
            this.nudGodzinaKoncowa.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudGodzinaKoncowa.Name = "nudGodzinaKoncowa";
            this.nudGodzinaKoncowa.Size = new System.Drawing.Size(63, 26);
            this.nudGodzinaKoncowa.TabIndex = 8;
            this.nudGodzinaKoncowa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudGodzinaKoncowa.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nudGodzinaKoncowa.ValueChanged += new System.EventHandler(this.nudGodzinaKoncowa_ValueChanged);
            // 
            // nudMinutyKoncowe
            // 
            this.nudMinutyKoncowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudMinutyKoncowe.Location = new System.Drawing.Point(415, 102);
            this.nudMinutyKoncowe.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutyKoncowe.Name = "nudMinutyKoncowe";
            this.nudMinutyKoncowe.Size = new System.Drawing.Size(63, 26);
            this.nudMinutyKoncowe.TabIndex = 9;
            this.nudMinutyKoncowe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMinutyKoncowe.ValueChanged += new System.EventHandler(this.nudMinutyKoncowe_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data początkowa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data końcowa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Godzina od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Minuty od";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Godzina do";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Minuty do";
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzukaj.Location = new System.Drawing.Point(179, 188);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(302, 49);
            this.btnSzukaj.TabIndex = 16;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 610);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1085, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(128, 17);
            this.toolStripStatusLabel1.Text = "Autor: Tomasz Gaładyk";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Enabled = false;
            this.btnZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapisz.Location = new System.Drawing.Point(515, 80);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(154, 157);
            this.btnZapisz.TabIndex = 17;
            this.btnZapisz.Text = "Zapisz raport na dysku";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1085, 632);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMinutyKoncowe);
            this.Controls.Add(this.nudGodzinaKoncowa);
            this.Controls.Add(this.nudMinutyPoczatkowe);
            this.Controls.Add(this.nudGodzinaPoczatkowa);
            this.Controls.Add(this.ckbCzyWszystkie);
            this.Controls.Add(this.dtpDataKoncowa);
            this.Controls.Add(this.dtpDataPoczatkowa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lstLinia);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Generator raportu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGodzinaPoczatkowa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutyPoczatkowe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGodzinaKoncowa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutyKoncowe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLinia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpDataPoczatkowa;
        private System.Windows.Forms.DateTimePicker dtpDataKoncowa;
        private System.Windows.Forms.CheckBox ckbCzyWszystkie;
        private System.Windows.Forms.NumericUpDown nudGodzinaPoczatkowa;
        private System.Windows.Forms.NumericUpDown nudMinutyPoczatkowe;
        private System.Windows.Forms.NumericUpDown nudGodzinaKoncowa;
        private System.Windows.Forms.NumericUpDown nudMinutyKoncowe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.DataGridViewTextBoxColumn CzasTrwania;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodzinaUruchomienia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brygada;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypZdarzenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiniaProdukcyjna;
        private System.Windows.Forms.DataGridViewTextBoxColumn StanId;
    }
}

