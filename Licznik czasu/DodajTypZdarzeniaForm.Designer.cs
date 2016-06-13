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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNowyTypZdarzenia = new System.Windows.Forms.TextBox();
            
            this.typZdarzeniaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaZdarzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typZdarzeniaIdDataGridViewTextBoxColumn,
            this.nazwaZdarzeniaDataGridViewTextBoxColumn});
            
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(325, 145);
            this.dataGridView1.TabIndex = 0;
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
            // txtNowyTypZdarzenia
            // 
            this.txtNowyTypZdarzenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNowyTypZdarzenia.Location = new System.Drawing.Point(16, 30);
            this.txtNowyTypZdarzenia.Name = "txtNowyTypZdarzenia";
            this.txtNowyTypZdarzenia.Size = new System.Drawing.Size(321, 26);
            this.txtNowyTypZdarzenia.TabIndex = 2;
            
            // 
            // typZdarzeniaIdDataGridViewTextBoxColumn
            // 
            this.typZdarzeniaIdDataGridViewTextBoxColumn.DataPropertyName = "TypZdarzeniaId";
            this.typZdarzeniaIdDataGridViewTextBoxColumn.HeaderText = "TypZdarzeniaId";
            this.typZdarzeniaIdDataGridViewTextBoxColumn.Name = "typZdarzeniaIdDataGridViewTextBoxColumn";
            this.typZdarzeniaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.typZdarzeniaIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazwaZdarzeniaDataGridViewTextBoxColumn
            // 
            this.nazwaZdarzeniaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazwaZdarzeniaDataGridViewTextBoxColumn.DataPropertyName = "NazwaZdarzenia";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaZdarzeniaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nazwaZdarzeniaDataGridViewTextBoxColumn.HeaderText = "Nazwa zdarzenia";
            this.nazwaZdarzeniaDataGridViewTextBoxColumn.Name = "nazwaZdarzeniaDataGridViewTextBoxColumn";
            this.nazwaZdarzeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(237, 62);
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
            this.btnZamknij.Location = new System.Drawing.Point(12, 256);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(325, 34);
            this.btnZamknij.TabIndex = 4;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // DodajTypZdarzeniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(349, 294);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtNowyTypZdarzenia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajTypZdarzeniaForm";
            this.Text = "Dodawanie nowego typu zdarzenia";
            this.Load += new System.EventHandler(this.DodajTypZdarzeniaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNowyTypZdarzenia;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn typZdarzeniaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaZdarzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnZamknij;
    }
}