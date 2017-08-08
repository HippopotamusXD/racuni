namespace Racuni
{
    partial class MainForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.KlijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Racun = new Racuni.Racun();
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dgvBaza = new System.Windows.Forms.DataGridView();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmBaza = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUredi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIzbrisi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDodaj = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajStavkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printajSveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prinajSelektiraneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rvRacun = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KlijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxImeFirme = new System.Windows.Forms.TextBox();
            this.textBoxImeFirme1 = new System.Windows.Forms.TextBox();
            this.textBoxImeFirme2 = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxMjesto = new System.Windows.Forms.TextBox();
            this.textBoxPostanskiBroj = new System.Windows.Forms.TextBox();
            this.textBoxOIB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.panelUredi = new System.Windows.Forms.Panel();
            this.panelDodaj = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonPonisti = new System.Windows.Forms.Button();
            this.buttonZavrsi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KlijentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racun)).BeginInit();
            this.MainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaza)).BeginInit();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KlijentBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelUredi.SuspendLayout();
            this.panelDodaj.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // KlijentiBindingSource
            // 
            this.KlijentiBindingSource.DataMember = "Klijenti";
            this.KlijentiBindingSource.DataSource = this.Racun;
            // 
            // Racun
            // 
            this.Racun.DataSetName = "Racun";
            this.Racun.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 2;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayoutPanel.Controls.Add(this.dgvBaza, 0, 1);
            this.MainLayoutPanel.Controls.Add(this.MenuStrip, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.rvRacun, 1, 1);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 2;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(784, 562);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // dgvBaza
            // 
            this.dgvBaza.AllowUserToAddRows = false;
            this.dgvBaza.AllowUserToDeleteRows = false;
            this.dgvBaza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaza.Location = new System.Drawing.Point(3, 28);
            this.dgvBaza.Name = "dgvBaza";
            this.dgvBaza.ReadOnly = true;
            this.dgvBaza.RowHeadersVisible = false;
            this.dgvBaza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaza.Size = new System.Drawing.Size(386, 531);
            this.dgvBaza.TabIndex = 1;
            this.dgvBaza.SelectionChanged += new System.EventHandler(this.dgvBaza_SelectionChanged);
            // 
            // MenuStrip
            // 
            this.MainLayoutPanel.SetColumnSpan(this.MenuStrip, 2);
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBaza,
            this.printajSveToolStripMenuItem,
            this.prinajSelektiraneToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.urediToolStripMenuItem,
            this.izbrisiToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(784, 25);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // tsmBaza
            // 
            this.tsmBaza.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUredi,
            this.tsmIzbrisi,
            this.tsmDodaj,
            this.dodajStavkeToolStripMenuItem});
            this.tsmBaza.Name = "tsmBaza";
            this.tsmBaza.Size = new System.Drawing.Size(43, 21);
            this.tsmBaza.Text = "Baza";
            // 
            // tsmUredi
            // 
            this.tsmUredi.Name = "tsmUredi";
            this.tsmUredi.Size = new System.Drawing.Size(195, 22);
            this.tsmUredi.Text = "Uredi Odabrano";
            this.tsmUredi.Click += new System.EventHandler(this.tsmUredi_Click);
            // 
            // tsmIzbrisi
            // 
            this.tsmIzbrisi.Name = "tsmIzbrisi";
            this.tsmIzbrisi.Size = new System.Drawing.Size(195, 22);
            this.tsmIzbrisi.Text = "Izbriši odabrano";
            this.tsmIzbrisi.Click += new System.EventHandler(this.tsmIzbrisi_Click);
            // 
            // tsmDodaj
            // 
            this.tsmDodaj.Name = "tsmDodaj";
            this.tsmDodaj.Size = new System.Drawing.Size(195, 22);
            this.tsmDodaj.Text = "Dodaj Novog Korisnika";
            this.tsmDodaj.Click += new System.EventHandler(this.tsmDodaj_Click);
            // 
            // dodajStavkeToolStripMenuItem
            // 
            this.dodajStavkeToolStripMenuItem.Name = "dodajStavkeToolStripMenuItem";
            this.dodajStavkeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.dodajStavkeToolStripMenuItem.Text = "Dodaj Stavke";
            // 
            // printajSveToolStripMenuItem
            // 
            this.printajSveToolStripMenuItem.Name = "printajSveToolStripMenuItem";
            this.printajSveToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.printajSveToolStripMenuItem.Text = "Printaj sve";
            this.printajSveToolStripMenuItem.Click += new System.EventHandler(this.printajSveToolStripMenuItem_Click);
            // 
            // prinajSelektiraneToolStripMenuItem
            // 
            this.prinajSelektiraneToolStripMenuItem.Name = "prinajSelektiraneToolStripMenuItem";
            this.prinajSelektiraneToolStripMenuItem.Size = new System.Drawing.Size(103, 21);
            this.prinajSelektiraneToolStripMenuItem.Text = "Prinaj odabrano";
            this.prinajSelektiraneToolStripMenuItem.Click += new System.EventHandler(this.prinajSelektiraneToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // urediToolStripMenuItem
            // 
            this.urediToolStripMenuItem.Name = "urediToolStripMenuItem";
            this.urediToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.urediToolStripMenuItem.Text = "Uredi";
            // 
            // izbrisiToolStripMenuItem
            // 
            this.izbrisiToolStripMenuItem.Name = "izbrisiToolStripMenuItem";
            this.izbrisiToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.izbrisiToolStripMenuItem.Text = "Izbrisi";
            this.izbrisiToolStripMenuItem.Click += new System.EventHandler(this.izbrisiToolStripMenuItem_Click);
            // 
            // rvRacun
            // 
            this.rvRacun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvRacun.DocumentMapWidth = 12;
            reportDataSource1.Name = "Racun";
            reportDataSource1.Value = this.KlijentiBindingSource;
            this.rvRacun.LocalReport.DataSources.Add(reportDataSource1);
            this.rvRacun.LocalReport.ReportEmbeddedResource = "Racuni.Racun.rdlc";
            this.rvRacun.Location = new System.Drawing.Point(395, 28);
            this.rvRacun.Name = "rvRacun";
            this.rvRacun.Size = new System.Drawing.Size(386, 531);
            this.rvRacun.TabIndex = 2;
            this.rvRacun.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.02062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.97938F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxImeFirme, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxImeFirme1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxImeFirme2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAdresa, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMjesto, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPostanskiBroj, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxOIB, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxID, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(436, 237);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime Firme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime Firme 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ime Firme 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mjesto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Poštanski Broj";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "OIB";
            // 
            // textBoxImeFirme
            // 
            this.textBoxImeFirme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxImeFirme.Location = new System.Drawing.Point(151, 33);
            this.textBoxImeFirme.Name = "textBoxImeFirme";
            this.textBoxImeFirme.Size = new System.Drawing.Size(282, 20);
            this.textBoxImeFirme.TabIndex = 7;
            this.textBoxImeFirme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxImeFirme_KeyDown);
            // 
            // textBoxImeFirme1
            // 
            this.textBoxImeFirme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxImeFirme1.Location = new System.Drawing.Point(151, 63);
            this.textBoxImeFirme1.Name = "textBoxImeFirme1";
            this.textBoxImeFirme1.Size = new System.Drawing.Size(282, 20);
            this.textBoxImeFirme1.TabIndex = 8;
            this.textBoxImeFirme1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxImeFirme1_KeyDown);
            // 
            // textBoxImeFirme2
            // 
            this.textBoxImeFirme2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxImeFirme2.Location = new System.Drawing.Point(151, 93);
            this.textBoxImeFirme2.Name = "textBoxImeFirme2";
            this.textBoxImeFirme2.Size = new System.Drawing.Size(282, 20);
            this.textBoxImeFirme2.TabIndex = 9;
            this.textBoxImeFirme2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxImeFirme2_KeyDown);
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAdresa.Location = new System.Drawing.Point(151, 123);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(282, 20);
            this.textBoxAdresa.TabIndex = 10;
            this.textBoxAdresa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAdresa_KeyDown);
            // 
            // textBoxMjesto
            // 
            this.textBoxMjesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMjesto.Location = new System.Drawing.Point(151, 153);
            this.textBoxMjesto.Name = "textBoxMjesto";
            this.textBoxMjesto.Size = new System.Drawing.Size(282, 20);
            this.textBoxMjesto.TabIndex = 11;
            this.textBoxMjesto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMjesto_KeyDown);
            // 
            // textBoxPostanskiBroj
            // 
            this.textBoxPostanskiBroj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPostanskiBroj.Location = new System.Drawing.Point(151, 183);
            this.textBoxPostanskiBroj.Name = "textBoxPostanskiBroj";
            this.textBoxPostanskiBroj.Size = new System.Drawing.Size(282, 20);
            this.textBoxPostanskiBroj.TabIndex = 12;
            this.textBoxPostanskiBroj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPostanskiBroj_KeyDown);
            // 
            // textBoxOIB
            // 
            this.textBoxOIB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOIB.Location = new System.Drawing.Point(151, 213);
            this.textBoxOIB.Name = "textBoxOIB";
            this.textBoxOIB.Size = new System.Drawing.Size(282, 20);
            this.textBoxOIB.TabIndex = 13;
            this.textBoxOIB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOIB_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxID.Location = new System.Drawing.Point(151, 3);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(282, 20);
            this.textBoxID.TabIndex = 15;
            // 
            // panelUredi
            // 
            this.panelUredi.Controls.Add(this.panelDodaj);
            this.panelUredi.Controls.Add(this.buttonPonisti);
            this.panelUredi.Controls.Add(this.buttonZavrsi);
            this.panelUredi.Controls.Add(this.tableLayoutPanel1);
            this.panelUredi.Location = new System.Drawing.Point(170, 117);
            this.panelUredi.Name = "panelUredi";
            this.panelUredi.Size = new System.Drawing.Size(443, 277);
            this.panelUredi.TabIndex = 1;
            this.panelUredi.Visible = false;
            // 
            // panelDodaj
            // 
            this.panelDodaj.Controls.Add(this.tableLayoutPanel2);
            this.panelDodaj.Location = new System.Drawing.Point(0, 0);
            this.panelDodaj.Name = "panelDodaj";
            this.panelDodaj.Size = new System.Drawing.Size(443, 247);
            this.panelDodaj.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.02062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.97938F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox5, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBox6, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBox7, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 7);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(443, 277);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 30);
            this.label10.TabIndex = 1;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 30);
            this.label11.TabIndex = 2;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 30);
            this.label12.TabIndex = 3;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 30);
            this.label13.TabIndex = 4;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 30);
            this.label14.TabIndex = 5;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 30);
            this.label15.TabIndex = 6;
            this.label15.Text = "label15";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(153, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(153, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(153, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(287, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(153, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(287, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(153, 123);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(287, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(153, 153);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(287, 20);
            this.textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Location = new System.Drawing.Point(153, 183);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(287, 20);
            this.textBox7.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonPonisti
            // 
            this.buttonPonisti.Location = new System.Drawing.Point(298, 247);
            this.buttonPonisti.Name = "buttonPonisti";
            this.buttonPonisti.Size = new System.Drawing.Size(139, 23);
            this.buttonPonisti.TabIndex = 2;
            this.buttonPonisti.Text = "Poništi";
            this.buttonPonisti.UseVisualStyleBackColor = true;
            this.buttonPonisti.Click += new System.EventHandler(this.buttonPonisti_Click);
            // 
            // buttonZavrsi
            // 
            this.buttonZavrsi.Location = new System.Drawing.Point(10, 247);
            this.buttonZavrsi.Name = "buttonZavrsi";
            this.buttonZavrsi.Size = new System.Drawing.Size(139, 23);
            this.buttonZavrsi.TabIndex = 1;
            this.buttonZavrsi.Text = "Završi";
            this.buttonZavrsi.UseVisualStyleBackColor = true;
            this.buttonZavrsi.Click += new System.EventHandler(this.buttonZavrsi_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panelUredi);
            this.Controls.Add(this.MainLayoutPanel);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Racuni";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KlijentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racun)).EndInit();
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaza)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KlijentBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelUredi.ResumeLayout(false);
            this.panelDodaj.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmBaza;
        private System.Windows.Forms.ToolStripMenuItem tsmUredi;
        private System.Windows.Forms.ToolStripMenuItem tsmIzbrisi;
        private System.Windows.Forms.ToolStripMenuItem tsmDodaj;
        private System.Windows.Forms.DataGridView dgvBaza;
        private Microsoft.Reporting.WinForms.ReportViewer rvRacun;
        private System.Windows.Forms.BindingSource KlijentBindingSource;
        private System.Windows.Forms.BindingSource KlijentiBindingSource;
        private Racun Racun;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printajSveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prinajSelektiraneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izbrisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajStavkeToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxImeFirme;
        private System.Windows.Forms.TextBox textBoxImeFirme1;
        private System.Windows.Forms.TextBox textBoxImeFirme2;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox textBoxMjesto;
        private System.Windows.Forms.TextBox textBoxPostanskiBroj;
        private System.Windows.Forms.TextBox textBoxOIB;
        private System.Windows.Forms.Panel panelUredi;
        private System.Windows.Forms.Button buttonPonisti;
        private System.Windows.Forms.Button buttonZavrsi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Panel panelDodaj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

