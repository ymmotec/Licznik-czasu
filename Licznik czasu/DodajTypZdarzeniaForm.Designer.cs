namespace Licznik_czasu
{
    partial class DodajTypZdarzeniaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListaTypowZdarzen = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.cmbTypDoDodania = new System.Windows.Forms.ComboBox();
            this.TypZdarzeniaIdDataGridTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwaZdarzeniaDataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTypowZdarzen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaTypowZdarzen
            // 
            this.dgvListaTypowZdarzen.AllowUserToAddRows = false;
            this.dgvListaTypowZdarzen.AllowUserToDeleteRows = false;
            this.dgvListaTypowZdarzen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaTypowZdarzen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTypowZdarzen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypZdarzeniaIdDataGridTextBoxColumn,
            this.NazwaZdarzeniaDataGridViewColumn});
            this.dgvListaTypowZdarzen.Location = new System.Drawing.Point(12, 93);
            this.dgvListaTypowZdarzen.Name = "dgvListaTypowZdarzen";
            this.dgvListaTypowZdarzen.ReadOnly = true;
            this.dgvListaTypowZdarzen.Size = new System.Drawing.Size(325, 189);
            this.dgvListaTypowZdarzen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wpisz nazwę nowego zdarzenia";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(262, 64);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZamknij.Location = new System.Drawing.Point(12, 284);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(325, 34);
            this.btnZamknij.TabIndex = 4;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // cmbTypDoDodania
            // 
            this.cmbTypDoDodania.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTypDoDodania.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTypDoDodania.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbTypDoDodania.FormattingEnabled = true;
            this.cmbTypDoDodania.Location = new System.Drawing.Point(16, 30);
            this.cmbTypDoDodania.Name = "cmbTypDoDodania";
            this.cmbTypDoDodania.Size = new System.Drawing.Size(321, 28);
            this.cmbTypDoDodania.TabIndex = 5;
            // 
            // TypZdarzeniaIdDataGridTextBoxColumn
            // 
            this.TypZdarzeniaIdDataGridTextBoxColumn.DataPropertyName = "TypZdarzeniaId";
            this.TypZdarzeniaIdDataGridTextBoxColumn.HeaderText = "ID Zdarzenia";
            this.TypZdarzeniaIdDataGridTextBoxColumn.Name = "TypZdarzeniaIdDataGridTextBoxColumn";
            this.TypZdarzeniaIdDataGridTextBoxColumn.ReadOnly = true;
            this.TypZdarzeniaIdDataGridTextBoxColumn.Visible = false;
            // 
            // NazwaZdarzeniaDataGridViewColumn
            // 
            this.NazwaZdarzeniaDataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazwaZdarzeniaDataGridViewColumn.DataPropertyName = "NazwaZdarzenia";
            this.NazwaZdarzeniaDataGridViewColumn.HeaderText = "Nazwa Zdarzenia";
            this.NazwaZdarzeniaDataGridViewColumn.Name = "NazwaZdarzeniaDataGridViewColumn";
            this.NazwaZdarzeniaDataGridViewColumn.ReadOnly = true;
            // 
            // DodajTypZdarzeniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(349, 329);
            this.Controls.Add(this.cmbTypDoDodania);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaTypowZdarzen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajTypZdarzeniaForm";
            this.Text = "Dodawanie nowego typu zdarzenia";
            this.Load += new System.EventHandler(this.DodajTypZdarzeniaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTypowZdarzen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaTypowZdarzen;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn typZdarzeniaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaZdarzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.ComboBox cmbTypDoDodania;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypZdarzeniaIdDataGridTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaZdarzeniaDataGridViewColumn;
    }
}