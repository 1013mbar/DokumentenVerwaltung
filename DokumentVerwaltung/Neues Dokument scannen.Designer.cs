namespace DokumentVerwaltung
{
    partial class Neues_Dokument_scannen
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
            this.btn_scannen = new System.Windows.Forms.Button();
            this.lbx_dokument_typ = new System.Windows.Forms.ListBox();
            this.dtp_datum = new System.Windows.Forms.DateTimePicker();
            this.tbx_bemerkung = new System.Windows.Forms.TextBox();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.lbl_dokument_typ = new System.Windows.Forms.Label();
            this.lbl_bemerkung = new System.Windows.Forms.Label();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_erstellen = new System.Windows.Forms.Button();
            this.rdb_spl = new System.Windows.Forms.RadioButton();
            this.rdb_dpl = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_scannen
            // 
            this.btn_scannen.Enabled = false;
            this.btn_scannen.Location = new System.Drawing.Point(277, 390);
            this.btn_scannen.Name = "btn_scannen";
            this.btn_scannen.Size = new System.Drawing.Size(88, 23);
            this.btn_scannen.TabIndex = 32;
            this.btn_scannen.Text = "Scannen";
            this.btn_scannen.UseVisualStyleBackColor = true;
            this.btn_scannen.Click += new System.EventHandler(this.btn_scannen_Click);
            // 
            // lbx_dokument_typ
            // 
            this.lbx_dokument_typ.FormattingEnabled = true;
            this.lbx_dokument_typ.Items.AddRange(new object[] {
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
            this.lbx_dokument_typ.Location = new System.Drawing.Point(15, 281);
            this.lbx_dokument_typ.Name = "lbx_dokument_typ";
            this.lbx_dokument_typ.Size = new System.Drawing.Size(127, 160);
            this.lbx_dokument_typ.TabIndex = 31;
            // 
            // dtp_datum
            // 
            this.dtp_datum.Location = new System.Drawing.Point(15, 86);
            this.dtp_datum.Name = "dtp_datum";
            this.dtp_datum.Size = new System.Drawing.Size(200, 20);
            this.dtp_datum.TabIndex = 29;
            // 
            // tbx_bemerkung
            // 
            this.tbx_bemerkung.Location = new System.Drawing.Point(15, 151);
            this.tbx_bemerkung.Multiline = true;
            this.tbx_bemerkung.Name = "tbx_bemerkung";
            this.tbx_bemerkung.Size = new System.Drawing.Size(231, 109);
            this.tbx_bemerkung.TabIndex = 27;
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(15, 25);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(211, 20);
            this.tbx_name.TabIndex = 26;
            this.tbx_name.TextChanged += new System.EventHandler(this.tbx_name_TextChanged);
            // 
            // lbl_dokument_typ
            // 
            this.lbl_dokument_typ.AutoSize = true;
            this.lbl_dokument_typ.Location = new System.Drawing.Point(12, 263);
            this.lbl_dokument_typ.Name = "lbl_dokument_typ";
            this.lbl_dokument_typ.Size = new System.Drawing.Size(77, 13);
            this.lbl_dokument_typ.TabIndex = 25;
            this.lbl_dokument_typ.Text = "Dokument Typ";
            // 
            // lbl_bemerkung
            // 
            this.lbl_bemerkung.AutoSize = true;
            this.lbl_bemerkung.Location = new System.Drawing.Point(12, 135);
            this.lbl_bemerkung.Name = "lbl_bemerkung";
            this.lbl_bemerkung.Size = new System.Drawing.Size(61, 13);
            this.lbl_bemerkung.TabIndex = 22;
            this.lbl_bemerkung.Text = "Bemerkung";
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Location = new System.Drawing.Point(12, 69);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(38, 13);
            this.lbl_datum.TabIndex = 21;
            this.lbl_datum.Text = "Datum";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 20;
            this.lbl_name.Text = "Name";
            // 
            // btn_erstellen
            // 
            this.btn_erstellen.Enabled = false;
            this.btn_erstellen.Location = new System.Drawing.Point(277, 419);
            this.btn_erstellen.Name = "btn_erstellen";
            this.btn_erstellen.Size = new System.Drawing.Size(88, 23);
            this.btn_erstellen.TabIndex = 33;
            this.btn_erstellen.Text = "Erstellen";
            this.btn_erstellen.UseVisualStyleBackColor = true;
            this.btn_erstellen.Click += new System.EventHandler(this.btn_erstellen_Click);
            // 
            // rdb_spl
            // 
            this.rdb_spl.AutoSize = true;
            this.rdb_spl.Checked = true;
            this.rdb_spl.Location = new System.Drawing.Point(277, 27);
            this.rdb_spl.Name = "rdb_spl";
            this.rdb_spl.Size = new System.Drawing.Size(61, 17);
            this.rdb_spl.TabIndex = 34;
            this.rdb_spl.TabStop = true;
            this.rdb_spl.Text = "Simplex";
            this.rdb_spl.UseVisualStyleBackColor = true;
            // 
            // rdb_dpl
            // 
            this.rdb_dpl.AutoSize = true;
            this.rdb_dpl.Location = new System.Drawing.Point(277, 50);
            this.rdb_dpl.Name = "rdb_dpl";
            this.rdb_dpl.Size = new System.Drawing.Size(58, 17);
            this.rdb_dpl.TabIndex = 35;
            this.rdb_dpl.Text = "Duplex";
            this.rdb_dpl.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Komprimerung:";
            // 
            // Neues_Dokument_scannen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rdb_dpl);
            this.Controls.Add(this.rdb_spl);
            this.Controls.Add(this.btn_erstellen);
            this.Controls.Add(this.btn_scannen);
            this.Controls.Add(this.lbx_dokument_typ);
            this.Controls.Add(this.dtp_datum);
            this.Controls.Add(this.tbx_bemerkung);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.lbl_dokument_typ);
            this.Controls.Add(this.lbl_bemerkung);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.lbl_name);
            this.Name = "Neues_Dokument_scannen";
            this.Text = "Neues_Dokument_scannen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_scannen;
        private System.Windows.Forms.ListBox lbx_dokument_typ;
        private System.Windows.Forms.DateTimePicker dtp_datum;
        private System.Windows.Forms.TextBox tbx_bemerkung;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label lbl_dokument_typ;
        private System.Windows.Forms.Label lbl_bemerkung;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_erstellen;
        private System.Windows.Forms.RadioButton rdb_spl;
        private System.Windows.Forms.RadioButton rdb_dpl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}