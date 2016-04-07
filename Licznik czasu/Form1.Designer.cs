namespace Licznik_czasu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajMaszynyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTypZdarzeniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generujRaportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCzasTrwania = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stanIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TypZdarzenia_TypZdarzeniaId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typZdarzeniasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licznikDataSet = new Licznik_czasu.licznikDataSet();
            this.godzinaUruchomieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czasTrwaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisAwariiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisPrzezbrojeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUruchomionoo = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLicznikSztuk = new System.Windows.Forms.Label();
            this.cmbStan = new System.Windows.Forms.ComboBox();
            this.btnZmienStan = new System.Windows.Forms.Button();
            this.btnStartMaszyny = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Licznik_czasu.licznikDataSetTableAdapters.TableAdapterManager();
            this.stanTableAdapter = new Licznik_czasu.licznikDataSetTableAdapters.StanTableAdapter();
            this.typZdarzeniasTableAdapter = new Licznik_czasu.licznikDataSetTableAdapters.TypZdarzeniasTableAdapter();
            this.arduino = new System.IO.Ports.SerialPort(this.components);
            this.rdbBrygada1 = new System.Windows.Forms.RadioButton();
            this.rdbBrygada2 = new System.Windows.Forms.RadioButton();
            this.rdbBrygada3 = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grBoxBrygada = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBiezacyCzasCyklu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIloscCykliNaMinute = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typZdarzeniasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licznikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grBoxBrygada.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajMaszynyToolStripMenuItem,
            this.dodajTypZdarzeniaToolStripMenuItem,
            this.generujRaportToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // dodajMaszynyToolStripMenuItem
            // 
            this.dodajMaszynyToolStripMenuItem.Name = "dodajMaszynyToolStripMenuItem";
            this.dodajMaszynyToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.dodajMaszynyToolStripMenuItem.Text = "Dodaj Maszyny";
            this.dodajMaszynyToolStripMenuItem.Click += new System.EventHandler(this.dodajMaszynyToolStripMenuItem_Click);
            // 
            // dodajTypZdarzeniaToolStripMenuItem
            // 
            this.dodajTypZdarzeniaToolStripMenuItem.Name = "dodajTypZdarzeniaToolStripMenuItem";
            this.dodajTypZdarzeniaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.dodajTypZdarzeniaToolStripMenuItem.Text = "Dodaj typ zdarzenia";
            this.dodajTypZdarzeniaToolStripMenuItem.Click += new System.EventHandler(this.dodajTypZdarzeniaToolStripMenuItem_Click);
            // 
            // generujRaportToolStripMenuItem
            // 
            this.generujRaportToolStripMenuItem.Name = "generujRaportToolStripMenuItem";
            this.generujRaportToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.generujRaportToolStripMenuItem.Text = "Generuj raport";
            this.generujRaportToolStripMenuItem.Click += new System.EventHandler(this.generujRaportToolStripMenuItem_Click);
            // 
            // lblCzasTrwania
            // 
            this.lblCzasTrwania.AutoSize = true;
            this.lblCzasTrwania.ForeColor = System.Drawing.Color.Red;
            this.lblCzasTrwania.Location = new System.Drawing.Point(212, 132);
            this.lblCzasTrwania.Name = "lblCzasTrwania";
            this.lblCzasTrwania.Size = new System.Drawing.Size(20, 24);
            this.lblCzasTrwania.TabIndex = 5;
            this.lblCzasTrwania.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stanIdDataGridViewTextBoxColumn,
            this.TypZdarzenia_TypZdarzeniaId,
            this.godzinaUruchomieniaDataGridViewTextBoxColumn,
            this.czasTrwaniaDataGridViewTextBoxColumn,
            this.opisAwariiDataGridViewTextBoxColumn,
            this.opisPrzezbrojeniaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 306);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(859, 302);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // stanIdDataGridViewTextBoxColumn
            // 
            this.stanIdDataGridViewTextBoxColumn.DataPropertyName = "StanId";
            this.stanIdDataGridViewTextBoxColumn.HeaderText = "StanId";
            this.stanIdDataGridViewTextBoxColumn.Name = "stanIdDataGridViewTextBoxColumn";
            this.stanIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.stanIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stanIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stanIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // TypZdarzenia_TypZdarzeniaId
            // 
            this.TypZdarzenia_TypZdarzeniaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypZdarzenia_TypZdarzeniaId.DataPropertyName = "TypZdarzenia_TypZdarzeniaId";
            this.TypZdarzenia_TypZdarzeniaId.DataSource = this.typZdarzeniasBindingSource;
            this.TypZdarzenia_TypZdarzeniaId.DisplayMember = "NazwaZdarzenia";
            this.TypZdarzenia_TypZdarzeniaId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TypZdarzenia_TypZdarzeniaId.HeaderText = "Typ Zdarzenia";
            this.TypZdarzenia_TypZdarzeniaId.Name = "TypZdarzenia_TypZdarzeniaId";
            this.TypZdarzenia_TypZdarzeniaId.ReadOnly = true;
            this.TypZdarzenia_TypZdarzeniaId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypZdarzenia_TypZdarzeniaId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TypZdarzenia_TypZdarzeniaId.ValueMember = "TypZdarzeniaId";
            // 
            // typZdarzeniasBindingSource
            // 
            this.typZdarzeniasBindingSource.DataMember = "TypZdarzenias";
            this.typZdarzeniasBindingSource.DataSource = this.licznikDataSet;
            // 
            // licznikDataSet
            // 
            this.licznikDataSet.DataSetName = "licznikDataSet";
            this.licznikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // godzinaUruchomieniaDataGridViewTextBoxColumn
            // 
            this.godzinaUruchomieniaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.godzinaUruchomieniaDataGridViewTextBoxColumn.DataPropertyName = "GodzinaUruchomienia";
            this.godzinaUruchomieniaDataGridViewTextBoxColumn.HeaderText = "Godzina Uruchomienia";
            this.godzinaUruchomieniaDataGridViewTextBoxColumn.Name = "godzinaUruchomieniaDataGridViewTextBoxColumn";
            this.godzinaUruchomieniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // czasTrwaniaDataGridViewTextBoxColumn
            // 
            this.czasTrwaniaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.czasTrwaniaDataGridViewTextBoxColumn.DataPropertyName = "CzasTrwania";
            this.czasTrwaniaDataGridViewTextBoxColumn.HeaderText = "Czas Trwania";
            this.czasTrwaniaDataGridViewTextBoxColumn.Name = "czasTrwaniaDataGridViewTextBoxColumn";
            this.czasTrwaniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisAwariiDataGridViewTextBoxColumn
            // 
            this.opisAwariiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opisAwariiDataGridViewTextBoxColumn.DataPropertyName = "OpisAwarii";
            this.opisAwariiDataGridViewTextBoxColumn.HeaderText = "Opis Awarii";
            this.opisAwariiDataGridViewTextBoxColumn.Name = "opisAwariiDataGridViewTextBoxColumn";
            this.opisAwariiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisPrzezbrojeniaDataGridViewTextBoxColumn
            // 
            this.opisPrzezbrojeniaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opisPrzezbrojeniaDataGridViewTextBoxColumn.DataPropertyName = "OpisPrzezbrojenia";
            this.opisPrzezbrojeniaDataGridViewTextBoxColumn.HeaderText = "Opis Przezbrojenia";
            this.opisPrzezbrojeniaDataGridViewTextBoxColumn.Name = "opisPrzezbrojeniaDataGridViewTextBoxColumn";
            this.opisPrzezbrojeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stanBindingSource
            // 
            this.stanBindingSource.DataMember = "Stan";
            this.stanBindingSource.DataSource = this.licznikDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.lblUruchomionoo);
            this.groupBox1.Controls.Add(this.lblOpis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblCzasTrwania);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 187);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stan obecny";
            // 
            // lblUruchomionoo
            // 
            this.lblUruchomionoo.AutoSize = true;
            this.lblUruchomionoo.Location = new System.Drawing.Point(212, 90);
            this.lblUruchomionoo.Name = "lblUruchomionoo";
            this.lblUruchomionoo.Size = new System.Drawing.Size(20, 24);
            this.lblUruchomionoo.TabIndex = 7;
            this.lblUruchomionoo.Text = "0";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(212, 48);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(20, 24);
            this.lblOpis.TabIndex = 6;
            this.lblOpis.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Czas trwania:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Uruchomiono o:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Opis:";
            // 
            // lblLicznikSztuk
            // 
            this.lblLicznikSztuk.AutoSize = true;
            this.lblLicznikSztuk.Location = new System.Drawing.Point(176, 92);
            this.lblLicznikSztuk.Name = "lblLicznikSztuk";
            this.lblLicznikSztuk.Size = new System.Drawing.Size(16, 17);
            this.lblLicznikSztuk.TabIndex = 13;
            this.lblLicznikSztuk.Text = "0";
            // 
            // cmbStan
            // 
            this.cmbStan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStan.DataSource = this.typZdarzeniasBindingSource;
            this.cmbStan.DisplayMember = "NazwaZdarzenia";
            this.cmbStan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbStan.FormattingEnabled = true;
            this.cmbStan.Location = new System.Drawing.Point(587, 86);
            this.cmbStan.Name = "cmbStan";
            this.cmbStan.Size = new System.Drawing.Size(284, 32);
            this.cmbStan.TabIndex = 8;
            this.cmbStan.ValueMember = "TypZdarzeniaId";
            this.cmbStan.SelectedIndexChanged += new System.EventHandler(this.cmbStan_SelectedIndexChanged);
            // 
            // btnZmienStan
            // 
            this.btnZmienStan.Enabled = false;
            this.btnZmienStan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZmienStan.Location = new System.Drawing.Point(587, 128);
            this.btnZmienStan.Name = "btnZmienStan";
            this.btnZmienStan.Size = new System.Drawing.Size(284, 37);
            this.btnZmienStan.TabIndex = 9;
            this.btnZmienStan.Text = "Zmień stan";
            this.btnZmienStan.UseVisualStyleBackColor = true;
            this.btnZmienStan.Click += new System.EventHandler(this.btnZmienStan_Click);
            // 
            // btnStartMaszyny
            // 
            this.btnStartMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStartMaszyny.Location = new System.Drawing.Point(587, 38);
            this.btnStartMaszyny.Name = "btnStartMaszyny";
            this.btnStartMaszyny.Size = new System.Drawing.Size(284, 37);
            this.btnStartMaszyny.TabIndex = 10;
            this.btnStartMaszyny.Text = "Start maszyny";
            this.btnStartMaszyny.UseVisualStyleBackColor = true;
            this.btnStartMaszyny.Click += new System.EventHandler(this.btnStartMaszyny_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.LiniaTableAdapter = null;
            this.tableAdapterManager.MaszynyTableAdapter = null;
            this.tableAdapterManager.StanTableAdapter = null;
            this.tableAdapterManager.TypZdarzeniasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Licznik_czasu.licznikDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stanTableAdapter
            // 
            this.stanTableAdapter.ClearBeforeFill = true;
            // 
            // typZdarzeniasTableAdapter
            // 
            this.typZdarzeniasTableAdapter.ClearBeforeFill = true;
            // 
            // arduino
            // 
            this.arduino.PortName = "COM4";
            this.arduino.ReadTimeout = 500;
            this.arduino.RtsEnable = true;
            this.arduino.WriteTimeout = 500;
            this.arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // rdbBrygada1
            // 
            this.rdbBrygada1.AutoSize = true;
            this.rdbBrygada1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbBrygada1.Location = new System.Drawing.Point(23, 32);
            this.rdbBrygada1.Name = "rdbBrygada1";
            this.rdbBrygada1.Size = new System.Drawing.Size(117, 24);
            this.rdbBrygada1.TabIndex = 14;
            this.rdbBrygada1.TabStop = true;
            this.rdbBrygada1.Text = "Brygada nr 1";
            this.rdbBrygada1.UseVisualStyleBackColor = true;
            this.rdbBrygada1.CheckedChanged += new System.EventHandler(this.rdbBrygada_CheckedChanged);
            // 
            // rdbBrygada2
            // 
            this.rdbBrygada2.AutoSize = true;
            this.rdbBrygada2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbBrygada2.Location = new System.Drawing.Point(223, 32);
            this.rdbBrygada2.Name = "rdbBrygada2";
            this.rdbBrygada2.Size = new System.Drawing.Size(117, 24);
            this.rdbBrygada2.TabIndex = 15;
            this.rdbBrygada2.TabStop = true;
            this.rdbBrygada2.Text = "Brygada nr 2";
            this.rdbBrygada2.UseVisualStyleBackColor = true;
            this.rdbBrygada2.CheckedChanged += new System.EventHandler(this.rdbBrygada_CheckedChanged);
            // 
            // rdbBrygada3
            // 
            this.rdbBrygada3.AutoSize = true;
            this.rdbBrygada3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbBrygada3.Location = new System.Drawing.Point(423, 32);
            this.rdbBrygada3.Name = "rdbBrygada3";
            this.rdbBrygada3.Size = new System.Drawing.Size(117, 24);
            this.rdbBrygada3.TabIndex = 16;
            this.rdbBrygada3.TabStop = true;
            this.rdbBrygada3.Text = "Brygada nr 3";
            this.rdbBrygada3.UseVisualStyleBackColor = true;
            this.rdbBrygada3.CheckedChanged += new System.EventHandler(this.rdbBrygada_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grBoxBrygada
            // 
            this.grBoxBrygada.Controls.Add(this.rdbBrygada1);
            this.grBoxBrygada.Controls.Add(this.rdbBrygada3);
            this.grBoxBrygada.Controls.Add(this.rdbBrygada2);
            this.grBoxBrygada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grBoxBrygada.Location = new System.Drawing.Point(12, 231);
            this.grBoxBrygada.Name = "grBoxBrygada";
            this.grBoxBrygada.Size = new System.Drawing.Size(569, 69);
            this.grBoxBrygada.TabIndex = 17;
            this.grBoxBrygada.TabStop = false;
            this.grBoxBrygada.Text = "Brygada";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 621);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(921, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(128, 17);
            this.toolStripStatusLabel1.Text = "Autor: Tomasz Gaładyk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Bieżący czas cyklu";
            // 
            // lblBiezacyCzasCyklu
            // 
            this.lblBiezacyCzasCyklu.AutoSize = true;
            this.lblBiezacyCzasCyklu.Location = new System.Drawing.Point(176, 26);
            this.lblBiezacyCzasCyklu.Name = "lblBiezacyCzasCyklu";
            this.lblBiezacyCzasCyklu.Size = new System.Drawing.Size(16, 17);
            this.lblBiezacyCzasCyklu.TabIndex = 24;
            this.lblBiezacyCzasCyklu.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tempo:";
            // 
            // lblIloscCykliNaMinute
            // 
            this.lblIloscCykliNaMinute.AutoSize = true;
            this.lblIloscCykliNaMinute.Location = new System.Drawing.Point(176, 59);
            this.lblIloscCykliNaMinute.Name = "lblIloscCykliNaMinute";
            this.lblIloscCykliNaMinute.Size = new System.Drawing.Size(16, 17);
            this.lblIloscCykliNaMinute.TabIndex = 26;
            this.lblIloscCykliNaMinute.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Liczba cykli:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblLicznikSztuk);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblBiezacyCzasCyklu);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblIloscCykliNaMinute);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(587, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 116);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cykle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(921, 643);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grBoxBrygada);
            this.Controls.Add(this.btnStartMaszyny);
            this.Controls.Add(this.btnZmienStan);
            this.Controls.Add(this.cmbStan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Stan maszyny";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typZdarzeniasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licznikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grBoxBrygada.ResumeLayout(false);
            this.grBoxBrygada.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.Label lblCzasTrwania;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUruchomionoo;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStan;
        private System.Windows.Forms.Button btnZmienStan;
        private System.Windows.Forms.Button btnStartMaszyny;
        private licznikDataSet licznikDataSet;
        private licznikDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource stanBindingSource;
        private licznikDataSetTableAdapters.StanTableAdapter stanTableAdapter;
        private licznikDataSetTableAdapters.TypZdarzeniasTableAdapter typZdarzeniasTableAdapter;
        private System.Windows.Forms.BindingSource typZdarzeniasBindingSource;
        private System.IO.Ports.SerialPort arduino;
        private System.Windows.Forms.ToolStripMenuItem dodajMaszynyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generujRaportToolStripMenuItem;
        private System.Windows.Forms.Label lblLicznikSztuk;
        private System.Windows.Forms.ToolStripMenuItem dodajTypZdarzeniaToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdbBrygada1;
        private System.Windows.Forms.RadioButton rdbBrygada2;
        private System.Windows.Forms.RadioButton rdbBrygada3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox grBoxBrygada;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisPrzezbrojeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisAwariiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn czasTrwaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godzinaUruchomieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypZdarzenia_TypZdarzeniaId;
        private System.Windows.Forms.DataGridViewComboBoxColumn stanIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIloscCykliNaMinute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBiezacyCzasCyklu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

