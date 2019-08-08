namespace DokumentVerwaltung
{
    partial class Neues_Dokument
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
            this.lbl_datenpfad = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.lbl_bemerkung = new System.Windows.Forms.Label();
            this.lbl_dokument_typ = new System.Windows.Forms.Label();
            this.tbx_datenpfad = new System.Windows.Forms.TextBox();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.tbx_bemerkung = new System.Windows.Forms.TextBox();
            this.dtp_datum = new System.Windows.Forms.DateTimePicker();
            this.lbx_dokument_typ = new System.Windows.Forms.ListBox();
            this.btn_exp = new System.Windows.Forms.Button();
            this.btn_einfuegen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_liegenschafts_nr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_datenpfad
            // 
            this.lbl_datenpfad.AutoSize = true;
            this.lbl_datenpfad.Location = new System.Drawing.Point(13, 13);
            this.lbl_datenpfad.Name = "lbl_datenpfad";
            this.lbl_datenpfad.Size = new System.Drawing.Size(57, 13);
            this.lbl_datenpfad.TabIndex = 0;
            this.lbl_datenpfad.Text = "Datenpfad";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(13, 71);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Location = new System.Drawing.Point(13, 131);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(38, 13);
            this.lbl_datum.TabIndex = 2;
            this.lbl_datum.Text = "Datum";
            // 
            // lbl_bemerkung
            // 
            this.lbl_bemerkung.AutoSize = true;
            this.lbl_bemerkung.Location = new System.Drawing.Point(13, 197);
            this.lbl_bemerkung.Name = "lbl_bemerkung";
            this.lbl_bemerkung.Size = new System.Drawing.Size(61, 13);
            this.lbl_bemerkung.TabIndex = 3;
            this.lbl_bemerkung.Text = "Bemerkung";
            // 
            // lbl_dokument_typ
            // 
            this.lbl_dokument_typ.AutoSize = true;
            this.lbl_dokument_typ.Location = new System.Drawing.Point(13, 392);
            this.lbl_dokument_typ.Name = "lbl_dokument_typ";
            this.lbl_dokument_typ.Size = new System.Drawing.Size(77, 13);
            this.lbl_dokument_typ.TabIndex = 6;
            this.lbl_dokument_typ.Text = "Dokument Typ";
            // 
            // tbx_datenpfad
            // 
            this.tbx_datenpfad.Location = new System.Drawing.Point(16, 29);
            this.tbx_datenpfad.Name = "tbx_datenpfad";
            this.tbx_datenpfad.Size = new System.Drawing.Size(273, 20);
            this.tbx_datenpfad.TabIndex = 7;
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(16, 87);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(211, 20);
            this.tbx_name.TabIndex = 8;
            // 
            // tbx_bemerkung
            // 
            this.tbx_bemerkung.Location = new System.Drawing.Point(16, 213);
            this.tbx_bemerkung.Multiline = true;
            this.tbx_bemerkung.Name = "tbx_bemerkung";
            this.tbx_bemerkung.Size = new System.Drawing.Size(269, 109);
            this.tbx_bemerkung.TabIndex = 10;
            // 
            // dtp_datum
            // 
            this.dtp_datum.Location = new System.Drawing.Point(16, 148);
            this.dtp_datum.Name = "dtp_datum";
            this.dtp_datum.Size = new System.Drawing.Size(200, 20);
            this.dtp_datum.TabIndex = 15;
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
            this.lbx_dokument_typ.Location = new System.Drawing.Point(16, 408);
            this.lbx_dokument_typ.Name = "lbx_dokument_typ";
            this.lbx_dokument_typ.Size = new System.Drawing.Size(120, 160);
            this.lbx_dokument_typ.TabIndex = 17;
            // 
            // btn_exp
            // 
            this.btn_exp.Location = new System.Drawing.Point(322, 27);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(75, 23);
            this.btn_exp.TabIndex = 18;
            this.btn_exp.Text = "Explorer";
            this.btn_exp.UseVisualStyleBackColor = true;
            this.btn_exp.Click += new System.EventHandler(this.btn_exp_Click);
            // 
            // btn_einfuegen
            // 
            this.btn_einfuegen.Location = new System.Drawing.Point(322, 84);
            this.btn_einfuegen.Name = "btn_einfuegen";
            this.btn_einfuegen.Size = new System.Drawing.Size(75, 23);
            this.btn_einfuegen.TabIndex = 19;
            this.btn_einfuegen.Text = "Erstellen";
            this.btn_einfuegen.UseVisualStyleBackColor = true;
            this.btn_einfuegen.Click += new System.EventHandler(this.btn_einfuegen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Liegenschafts Nr";
            // 
            // lbl_liegenschafts_nr
            // 
            this.lbl_liegenschafts_nr.AutoSize = true;
            this.lbl_liegenschafts_nr.Location = new System.Drawing.Point(16, 360);
            this.lbl_liegenschafts_nr.Name = "lbl_liegenschafts_nr";
            this.lbl_liegenschafts_nr.Size = new System.Drawing.Size(35, 13);
            this.lbl_liegenschafts_nr.TabIndex = 21;
            this.lbl_liegenschafts_nr.Text = "label2";
            // 
            // Neues_Dokument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 580);
            this.Controls.Add(this.lbl_liegenschafts_nr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_einfuegen);
            this.Controls.Add(this.btn_exp);
            this.Controls.Add(this.lbx_dokument_typ);
            this.Controls.Add(this.dtp_datum);
            this.Controls.Add(this.tbx_bemerkung);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.tbx_datenpfad);
            this.Controls.Add(this.lbl_dokument_typ);
            this.Controls.Add(this.lbl_bemerkung);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_datenpfad);
            this.Name = "Neues_Dokument";
            this.Text = "Neues_Dokument";
            this.Load += new System.EventHandler(this.Neues_Dokument_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_datenpfad;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.Label lbl_bemerkung;
        private System.Windows.Forms.Label lbl_dokument_typ;
        private System.Windows.Forms.TextBox tbx_datenpfad;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.TextBox tbx_bemerkung;
        private System.Windows.Forms.DateTimePicker dtp_datum;
        private System.Windows.Forms.ListBox lbx_dokument_typ;
        private System.Windows.Forms.Button btn_exp;
        private System.Windows.Forms.Button btn_einfuegen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_liegenschafts_nr;
    }
}