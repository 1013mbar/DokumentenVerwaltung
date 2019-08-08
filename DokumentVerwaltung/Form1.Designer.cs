namespace DokumentVerwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dok_neu = new System.Windows.Forms.Button();
            this.dok_aendern = new System.Windows.Forms.Button();
            this.dok_loeschen = new System.Windows.Forms.Button();
            this.btn_alle = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gbx_dokumente = new System.Windows.Forms.GroupBox();
            this.gbx_lieg_aender = new System.Windows.Forms.GroupBox();
            this.btn_change_lg = new System.Windows.Forms.Button();
            this.tbx_neu_lg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_alt_lg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_aktuelle_liegenschaft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_scannen = new System.Windows.Forms.Button();
            this.btn_bemerkung = new System.Windows.Forms.Button();
            this.gbx_liegenschaften = new System.Windows.Forms.GroupBox();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.lbl_liegenschafts_filter = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_liegenschaft_loeschen = new System.Windows.Forms.Button();
            this.btn_liegenschaft_aendern = new System.Windows.Forms.Button();
            this.btn_neu_liegenschaft = new System.Windows.Forms.Button();
            this.gpx_filter = new System.Windows.Forms.GroupBox();
            this.gbx_filter_dok = new System.Windows.Forms.GroupBox();
            this.cbx_dok_typ = new System.Windows.Forms.CheckBox();
            this.lbx_filter_dok_typ = new System.Windows.Forms.ListBox();
            this.lbl_jahr = new System.Windows.Forms.Label();
            this.nud_jahr = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atomatischesEinlesenVonDatenAktivierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automatischesEinlesenVonDatenDeaktivierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postgreEinstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liegenschaftenÜberführenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pfadeÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabellenErstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einmaligEinlesenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbx_dokumente.SuspendLayout();
            this.gbx_lieg_aender.SuspendLayout();
            this.gbx_liegenschaften.SuspendLayout();
            this.gpx_filter.SuspendLayout();
            this.gbx_filter_dok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_jahr)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(883, 534);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // dok_neu
            // 
            this.dok_neu.Location = new System.Drawing.Point(9, 586);
            this.dok_neu.Name = "dok_neu";
            this.dok_neu.Size = new System.Drawing.Size(75, 40);
            this.dok_neu.TabIndex = 1;
            this.dok_neu.Text = "Neues Dokument";
            this.dok_neu.UseVisualStyleBackColor = true;
            this.dok_neu.Click += new System.EventHandler(this.dok_neu_Click);
            // 
            // dok_aendern
            // 
            this.dok_aendern.Location = new System.Drawing.Point(171, 586);
            this.dok_aendern.Name = "dok_aendern";
            this.dok_aendern.Size = new System.Drawing.Size(75, 40);
            this.dok_aendern.TabIndex = 2;
            this.dok_aendern.Text = "Dokument ändern";
            this.dok_aendern.UseVisualStyleBackColor = true;
            this.dok_aendern.Click += new System.EventHandler(this.dok_aendern_Click);
            // 
            // dok_loeschen
            // 
            this.dok_loeschen.Location = new System.Drawing.Point(90, 586);
            this.dok_loeschen.Name = "dok_loeschen";
            this.dok_loeschen.Size = new System.Drawing.Size(75, 40);
            this.dok_loeschen.TabIndex = 3;
            this.dok_loeschen.Text = "Dokument löschen";
            this.dok_loeschen.UseVisualStyleBackColor = true;
            this.dok_loeschen.Click += new System.EventHandler(this.dok_loeschen_Click);
            // 
            // btn_alle
            // 
            this.btn_alle.Location = new System.Drawing.Point(252, 586);
            this.btn_alle.Name = "btn_alle";
            this.btn_alle.Size = new System.Drawing.Size(75, 40);
            this.btn_alle.TabIndex = 4;
            this.btn_alle.Text = "Alle anzeigen";
            this.btn_alle.UseVisualStyleBackColor = true;
            this.btn_alle.Click += new System.EventHandler(this.btn_alle_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(461, 422);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // gbx_dokumente
            // 
            this.gbx_dokumente.Controls.Add(this.gbx_lieg_aender);
            this.gbx_dokumente.Controls.Add(this.button2);
            this.gbx_dokumente.Controls.Add(this.lbl_aktuelle_liegenschaft);
            this.gbx_dokumente.Controls.Add(this.label1);
            this.gbx_dokumente.Controls.Add(this.btn_scannen);
            this.gbx_dokumente.Controls.Add(this.btn_bemerkung);
            this.gbx_dokumente.Controls.Add(this.dataGridView1);
            this.gbx_dokumente.Controls.Add(this.dok_aendern);
            this.gbx_dokumente.Controls.Add(this.dok_loeschen);
            this.gbx_dokumente.Controls.Add(this.btn_alle);
            this.gbx_dokumente.Controls.Add(this.dok_neu);
            this.gbx_dokumente.Location = new System.Drawing.Point(514, 31);
            this.gbx_dokumente.Name = "gbx_dokumente";
            this.gbx_dokumente.Size = new System.Drawing.Size(895, 692);
            this.gbx_dokumente.TabIndex = 6;
            this.gbx_dokumente.TabStop = false;
            this.gbx_dokumente.Text = "Dokumente";
            // 
            // gbx_lieg_aender
            // 
            this.gbx_lieg_aender.Controls.Add(this.btn_change_lg);
            this.gbx_lieg_aender.Controls.Add(this.tbx_neu_lg);
            this.gbx_lieg_aender.Controls.Add(this.label3);
            this.gbx_lieg_aender.Controls.Add(this.tbx_alt_lg);
            this.gbx_lieg_aender.Controls.Add(this.label2);
            this.gbx_lieg_aender.Location = new System.Drawing.Point(333, 586);
            this.gbx_lieg_aender.Name = "gbx_lieg_aender";
            this.gbx_lieg_aender.Size = new System.Drawing.Size(328, 100);
            this.gbx_lieg_aender.TabIndex = 10;
            this.gbx_lieg_aender.TabStop = false;
            this.gbx_lieg_aender.Text = "Liegenscahfts-Nr ändern";
            // 
            // btn_change_lg
            // 
            this.btn_change_lg.Location = new System.Drawing.Point(205, 72);
            this.btn_change_lg.Name = "btn_change_lg";
            this.btn_change_lg.Size = new System.Drawing.Size(117, 23);
            this.btn_change_lg.TabIndex = 4;
            this.btn_change_lg.Text = "Liegenschaft ändern";
            this.btn_change_lg.UseVisualStyleBackColor = true;
            this.btn_change_lg.Click += new System.EventHandler(this.btn_change_lg_Click);
            // 
            // tbx_neu_lg
            // 
            this.tbx_neu_lg.Location = new System.Drawing.Point(185, 46);
            this.tbx_neu_lg.Name = "tbx_neu_lg";
            this.tbx_neu_lg.Size = new System.Drawing.Size(137, 20);
            this.tbx_neu_lg.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Neu";
            // 
            // tbx_alt_lg
            // 
            this.tbx_alt_lg.Location = new System.Drawing.Point(6, 46);
            this.tbx_alt_lg.Name = "tbx_alt_lg";
            this.tbx_alt_lg.Size = new System.Drawing.Size(147, 20);
            this.tbx_alt_lg.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alt";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 632);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Dokument speichern unter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_aktuelle_liegenschaft
            // 
            this.lbl_aktuelle_liegenschaft.AutoSize = true;
            this.lbl_aktuelle_liegenschaft.Location = new System.Drawing.Point(149, 26);
            this.lbl_aktuelle_liegenschaft.Name = "lbl_aktuelle_liegenschaft";
            this.lbl_aktuelle_liegenschaft.Size = new System.Drawing.Size(0, 13);
            this.lbl_aktuelle_liegenschaft.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Aktuelle Liegenschaft:";
            // 
            // btn_scannen
            // 
            this.btn_scannen.Location = new System.Drawing.Point(90, 632);
            this.btn_scannen.Name = "btn_scannen";
            this.btn_scannen.Size = new System.Drawing.Size(75, 39);
            this.btn_scannen.TabIndex = 6;
            this.btn_scannen.Text = "Dokument scannen";
            this.btn_scannen.UseVisualStyleBackColor = true;
            this.btn_scannen.Click += new System.EventHandler(this.btn_scannen_Click);
            // 
            // btn_bemerkung
            // 
            this.btn_bemerkung.Location = new System.Drawing.Point(9, 632);
            this.btn_bemerkung.Name = "btn_bemerkung";
            this.btn_bemerkung.Size = new System.Drawing.Size(75, 39);
            this.btn_bemerkung.TabIndex = 5;
            this.btn_bemerkung.Text = "Bemerkung anzeigen";
            this.btn_bemerkung.UseVisualStyleBackColor = true;
            this.btn_bemerkung.Click += new System.EventHandler(this.btn_bemerkung_Click);
            // 
            // gbx_liegenschaften
            // 
            this.gbx_liegenschaften.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbx_liegenschaften.Controls.Add(this.lbl_timer);
            this.gbx_liegenschaften.Controls.Add(this.lbl_liegenschafts_filter);
            this.gbx_liegenschaften.Controls.Add(this.textBox1);
            this.gbx_liegenschaften.Controls.Add(this.button1);
            this.gbx_liegenschaften.Controls.Add(this.btn_liegenschaft_loeschen);
            this.gbx_liegenschaften.Controls.Add(this.btn_liegenschaft_aendern);
            this.gbx_liegenschaften.Controls.Add(this.btn_neu_liegenschaft);
            this.gbx_liegenschaften.Controls.Add(this.dataGridView2);
            this.gbx_liegenschaften.Location = new System.Drawing.Point(13, 31);
            this.gbx_liegenschaften.Name = "gbx_liegenschaften";
            this.gbx_liegenschaften.Size = new System.Drawing.Size(495, 518);
            this.gbx_liegenschaften.TabIndex = 7;
            this.gbx_liegenschaften.TabStop = false;
            this.gbx_liegenschaften.Text = "Liegenschaften";
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(395, 22);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(0, 13);
            this.lbl_timer.TabIndex = 12;
            // 
            // lbl_liegenschafts_filter
            // 
            this.lbl_liegenschafts_filter.AutoSize = true;
            this.lbl_liegenschafts_filter.Location = new System.Drawing.Point(127, 22);
            this.lbl_liegenschafts_filter.Name = "lbl_liegenschafts_filter";
            this.lbl_liegenschafts_filter.Size = new System.Drawing.Size(0, 13);
            this.lbl_liegenschafts_filter.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Alle Liegenschaften";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_liegenschaft_loeschen
            // 
            this.btn_liegenschaft_loeschen.Location = new System.Drawing.Point(206, 474);
            this.btn_liegenschaft_loeschen.Name = "btn_liegenschaft_loeschen";
            this.btn_liegenschaft_loeschen.Size = new System.Drawing.Size(83, 37);
            this.btn_liegenschaft_loeschen.TabIndex = 8;
            this.btn_liegenschaft_loeschen.Text = "Liegenschaft löschen";
            this.btn_liegenschaft_loeschen.UseVisualStyleBackColor = true;
            this.btn_liegenschaft_loeschen.Click += new System.EventHandler(this.btn_liegenschaft_loeschen_Click);
            // 
            // btn_liegenschaft_aendern
            // 
            this.btn_liegenschaft_aendern.Location = new System.Drawing.Point(113, 473);
            this.btn_liegenschaft_aendern.Name = "btn_liegenschaft_aendern";
            this.btn_liegenschaft_aendern.Size = new System.Drawing.Size(87, 38);
            this.btn_liegenschaft_aendern.TabIndex = 7;
            this.btn_liegenschaft_aendern.Text = "Liegenschaft ändern";
            this.btn_liegenschaft_aendern.UseVisualStyleBackColor = true;
            this.btn_liegenschaft_aendern.Click += new System.EventHandler(this.btn_liegenschaft_aendern_Click);
            // 
            // btn_neu_liegenschaft
            // 
            this.btn_neu_liegenschaft.Location = new System.Drawing.Point(21, 472);
            this.btn_neu_liegenschaft.Name = "btn_neu_liegenschaft";
            this.btn_neu_liegenschaft.Size = new System.Drawing.Size(86, 40);
            this.btn_neu_liegenschaft.TabIndex = 6;
            this.btn_neu_liegenschaft.Text = "Neue Liegenschaft";
            this.btn_neu_liegenschaft.UseVisualStyleBackColor = true;
            this.btn_neu_liegenschaft.Click += new System.EventHandler(this.btn_neu_liegenschaft_Click);
            // 
            // gpx_filter
            // 
            this.gpx_filter.Controls.Add(this.gbx_filter_dok);
            this.gpx_filter.Location = new System.Drawing.Point(13, 555);
            this.gpx_filter.Name = "gpx_filter";
            this.gpx_filter.Size = new System.Drawing.Size(495, 221);
            this.gpx_filter.TabIndex = 8;
            this.gpx_filter.TabStop = false;
            this.gpx_filter.Text = "Filter";
            // 
            // gbx_filter_dok
            // 
            this.gbx_filter_dok.AutoSize = true;
            this.gbx_filter_dok.Controls.Add(this.cbx_dok_typ);
            this.gbx_filter_dok.Controls.Add(this.lbx_filter_dok_typ);
            this.gbx_filter_dok.Controls.Add(this.lbl_jahr);
            this.gbx_filter_dok.Controls.Add(this.nud_jahr);
            this.gbx_filter_dok.Location = new System.Drawing.Point(6, 19);
            this.gbx_filter_dok.Name = "gbx_filter_dok";
            this.gbx_filter_dok.Size = new System.Drawing.Size(483, 196);
            this.gbx_filter_dok.TabIndex = 2;
            this.gbx_filter_dok.TabStop = false;
            this.gbx_filter_dok.Text = "Dokumente";
            // 
            // cbx_dok_typ
            // 
            this.cbx_dok_typ.AutoSize = true;
            this.cbx_dok_typ.Location = new System.Drawing.Point(365, 19);
            this.cbx_dok_typ.Name = "cbx_dok_typ";
            this.cbx_dok_typ.Size = new System.Drawing.Size(96, 17);
            this.cbx_dok_typ.TabIndex = 4;
            this.cbx_dok_typ.Text = "Dokument Typ";
            this.cbx_dok_typ.UseVisualStyleBackColor = true;
            this.cbx_dok_typ.CheckedChanged += new System.EventHandler(this.cbx_dok_typ_CheckedChanged);
            // 
            // lbx_filter_dok_typ
            // 
            this.lbx_filter_dok_typ.Enabled = false;
            this.lbx_filter_dok_typ.FormattingEnabled = true;
            this.lbx_filter_dok_typ.Items.AddRange(new object[] {
            "Abrechnungen",
            "Ablesebelege",
            "Kostenbelege",
            "Rechnungen",
            "Legionellen",
            "Schriftverkehr",
            "Verträge",
            "Termine",
            "Kundenbelege",
            "Technische Dokumente",
            "Energieausweise",
            "MEG",
            "Sonstiges"});
            this.lbx_filter_dok_typ.Location = new System.Drawing.Point(237, 17);
            this.lbx_filter_dok_typ.Name = "lbx_filter_dok_typ";
            this.lbx_filter_dok_typ.Size = new System.Drawing.Size(120, 160);
            this.lbx_filter_dok_typ.TabIndex = 2;
            this.lbx_filter_dok_typ.SelectedIndexChanged += new System.EventHandler(this.lbx_filter_dok_typ_SelectedIndexChanged);
            // 
            // lbl_jahr
            // 
            this.lbl_jahr.AutoSize = true;
            this.lbl_jahr.Location = new System.Drawing.Point(94, 27);
            this.lbl_jahr.Name = "lbl_jahr";
            this.lbl_jahr.Size = new System.Drawing.Size(27, 13);
            this.lbl_jahr.TabIndex = 1;
            this.lbl_jahr.Text = "Jahr";
            // 
            // nud_jahr
            // 
            this.nud_jahr.Location = new System.Drawing.Point(93, 43);
            this.nud_jahr.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.nud_jahr.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.nud_jahr.Name = "nud_jahr";
            this.nud_jahr.Size = new System.Drawing.Size(120, 20);
            this.nud_jahr.TabIndex = 0;
            this.nud_jahr.Value = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            this.nud_jahr.ValueChanged += new System.EventHandler(this.nud_jahr_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1421, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atomatischesEinlesenVonDatenAktivierenToolStripMenuItem,
            this.automatischesEinlesenVonDatenDeaktivierenToolStripMenuItem,
            this.postgreEinstellungenToolStripMenuItem,
            this.liegenschaftenÜberführenToolStripMenuItem,
            this.pfadeÄndernToolStripMenuItem,
            this.tabellenErstellenToolStripMenuItem,
            this.einmaligEinlesenToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.einstellungenToolStripMenuItem.Text = "Weitere Funktionen";
            // 
            // atomatischesEinlesenVonDatenAktivierenToolStripMenuItem
            // 
            this.atomatischesEinlesenVonDatenAktivierenToolStripMenuItem.Name = "atomatischesEinlesenVonDatenAktivierenToolStripMenuItem";
            this.atomatischesEinlesenVonDatenAktivierenToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.atomatischesEinlesenVonDatenAktivierenToolStripMenuItem.Text = "Automatisches Einlesen von Daten aktivieren";
            this.atomatischesEinlesenVonDatenAktivierenToolStripMenuItem.Click += new System.EventHandler(this.atomatischesEinlesenVonDatenAktivierenToolStripMenuItem_Click);
            // 
            // automatischesEinlesenVonDatenDeaktivierenToolStripMenuItem
            // 
            this.automatischesEinlesenVonDatenDeaktivierenToolStripMenuItem.Name = "automatischesEinlesenVonDatenDeaktivierenToolStripMenuItem";
            this.automatischesEinlesenVonDatenDeaktivierenToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.automatischesEinlesenVonDatenDeaktivierenToolStripMenuItem.Text = "Automatisches Einlesen von Daten deaktivieren";
            this.automatischesEinlesenVonDatenDeaktivierenToolStripMenuItem.Click += new System.EventHandler(this.automatischesEinlesenVonDatenDeaktivierenToolStripMenuItem_Click);
            // 
            // postgreEinstellungenToolStripMenuItem
            // 
            this.postgreEinstellungenToolStripMenuItem.Name = "postgreEinstellungenToolStripMenuItem";
            this.postgreEinstellungenToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.postgreEinstellungenToolStripMenuItem.Text = "Postgre Einstellungen";
            this.postgreEinstellungenToolStripMenuItem.Click += new System.EventHandler(this.postgreEinstellungenToolStripMenuItem_Click);
            // 
            // liegenschaftenÜberführenToolStripMenuItem
            // 
            this.liegenschaftenÜberführenToolStripMenuItem.Name = "liegenschaftenÜberführenToolStripMenuItem";
            this.liegenschaftenÜberführenToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.liegenschaftenÜberführenToolStripMenuItem.Text = "Liegenschaften überführen";
            this.liegenschaftenÜberführenToolStripMenuItem.Click += new System.EventHandler(this.liegenschaftenÜberführenToolStripMenuItem_Click_1);
            // 
            // pfadeÄndernToolStripMenuItem
            // 
            this.pfadeÄndernToolStripMenuItem.Name = "pfadeÄndernToolStripMenuItem";
            this.pfadeÄndernToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.pfadeÄndernToolStripMenuItem.Text = "Pfade ändern";
            this.pfadeÄndernToolStripMenuItem.Click += new System.EventHandler(this.pfadeÄndernToolStripMenuItem_Click);
            // 
            // tabellenErstellenToolStripMenuItem
            // 
            this.tabellenErstellenToolStripMenuItem.Name = "tabellenErstellenToolStripMenuItem";
            this.tabellenErstellenToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.tabellenErstellenToolStripMenuItem.Text = "Tabellen erstellen";
            this.tabellenErstellenToolStripMenuItem.Visible = false;
            this.tabellenErstellenToolStripMenuItem.Click += new System.EventHandler(this.tabellenErstellenToolStripMenuItem_Click);
            // 
            // einmaligEinlesenToolStripMenuItem
            // 
            this.einmaligEinlesenToolStripMenuItem.Name = "einmaligEinlesenToolStripMenuItem";
            this.einmaligEinlesenToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.einmaligEinlesenToolStripMenuItem.Text = "Einmalig einlesen";
            this.einmaligEinlesenToolStripMenuItem.Click += new System.EventHandler(this.einmaligEinlesenToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1421, 778);
            this.Controls.Add(this.gpx_filter);
            this.Controls.Add(this.gbx_liegenschaften);
            this.Controls.Add(this.gbx_dokumente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dokument Verwaltung";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbx_dokumente.ResumeLayout(false);
            this.gbx_dokumente.PerformLayout();
            this.gbx_lieg_aender.ResumeLayout(false);
            this.gbx_lieg_aender.PerformLayout();
            this.gbx_liegenschaften.ResumeLayout(false);
            this.gbx_liegenschaften.PerformLayout();
            this.gpx_filter.ResumeLayout(false);
            this.gpx_filter.PerformLayout();
            this.gbx_filter_dok.ResumeLayout(false);
            this.gbx_filter_dok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_jahr)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dok_neu;
        private System.Windows.Forms.Button dok_aendern;
        private System.Windows.Forms.Button dok_loeschen;
        private System.Windows.Forms.Button btn_alle;
        private System.Windows.Forms.GroupBox gbx_dokumente;
        private System.Windows.Forms.GroupBox gbx_liegenschaften;
        private System.Windows.Forms.Button btn_neu_liegenschaft;
        private System.Windows.Forms.GroupBox gpx_filter;
        private System.Windows.Forms.Label lbl_jahr;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_bemerkung;
        private System.Windows.Forms.Button btn_liegenschaft_loeschen;
        private System.Windows.Forms.Button btn_liegenschaft_aendern;
        internal System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox gbx_filter_dok;
        private System.Windows.Forms.Button btn_scannen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbx_dok_typ;
        private System.Windows.Forms.ListBox lbx_filter_dok_typ;
        private System.Windows.Forms.Label lbl_liegenschafts_filter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atomatischesEinlesenVonDatenAktivierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automatischesEinlesenVonDatenDeaktivierenToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem postgreEinstellungenToolStripMenuItem;
        public System.Windows.Forms.NumericUpDown nud_jahr;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem liegenschaftenÜberführenToolStripMenuItem;
        public System.Windows.Forms.Label lbl_aktuelle_liegenschaft;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem pfadeÄndernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabellenErstellenToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.ToolStripMenuItem einmaligEinlesenToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbx_lieg_aender;
        private System.Windows.Forms.Button btn_change_lg;
        private System.Windows.Forms.TextBox tbx_neu_lg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_alt_lg;
        private System.Windows.Forms.Label label2;
    }
}

