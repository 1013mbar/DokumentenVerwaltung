namespace DokumentVerwaltung
{
    partial class Neue_Liegenschaft
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
            this.lbl_liegenschafts_nr = new System.Windows.Forms.Label();
            this.lbl_strasse = new System.Windows.Forms.Label();
            this.lbl_plz = new System.Windows.Forms.Label();
            this.lbl_ort = new System.Windows.Forms.Label();
            this.tbx_liegenschafts_nr = new System.Windows.Forms.TextBox();
            this.gbx_adresse = new System.Windows.Forms.GroupBox();
            this.tbx_ort = new System.Windows.Forms.TextBox();
            this.tbx_plz = new System.Windows.Forms.TextBox();
            this.tbx_strasse = new System.Windows.Forms.TextBox();
            this.btn_erstellen = new System.Windows.Forms.Button();
            this.gbx_adresse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_liegenschafts_nr
            // 
            this.lbl_liegenschafts_nr.AutoSize = true;
            this.lbl_liegenschafts_nr.Location = new System.Drawing.Point(13, 13);
            this.lbl_liegenschafts_nr.Name = "lbl_liegenschafts_nr";
            this.lbl_liegenschafts_nr.Size = new System.Drawing.Size(90, 13);
            this.lbl_liegenschafts_nr.TabIndex = 0;
            this.lbl_liegenschafts_nr.Text = "Liegenschafts Nr.";
            // 
            // lbl_strasse
            // 
            this.lbl_strasse.AutoSize = true;
            this.lbl_strasse.Location = new System.Drawing.Point(6, 25);
            this.lbl_strasse.Name = "lbl_strasse";
            this.lbl_strasse.Size = new System.Drawing.Size(38, 13);
            this.lbl_strasse.TabIndex = 1;
            this.lbl_strasse.Text = "Straße";
            // 
            // lbl_plz
            // 
            this.lbl_plz.AutoSize = true;
            this.lbl_plz.Location = new System.Drawing.Point(6, 75);
            this.lbl_plz.Name = "lbl_plz";
            this.lbl_plz.Size = new System.Drawing.Size(27, 13);
            this.lbl_plz.TabIndex = 2;
            this.lbl_plz.Text = "PLZ";
            // 
            // lbl_ort
            // 
            this.lbl_ort.AutoSize = true;
            this.lbl_ort.Location = new System.Drawing.Point(9, 124);
            this.lbl_ort.Name = "lbl_ort";
            this.lbl_ort.Size = new System.Drawing.Size(21, 13);
            this.lbl_ort.TabIndex = 3;
            this.lbl_ort.Text = "Ort";
            // 
            // tbx_liegenschafts_nr
            // 
            this.tbx_liegenschafts_nr.Location = new System.Drawing.Point(16, 30);
            this.tbx_liegenschafts_nr.MaxLength = 10;
            this.tbx_liegenschafts_nr.Name = "tbx_liegenschafts_nr";
            this.tbx_liegenschafts_nr.Size = new System.Drawing.Size(186, 20);
            this.tbx_liegenschafts_nr.TabIndex = 4;
            // 
            // gbx_adresse
            // 
            this.gbx_adresse.Controls.Add(this.tbx_ort);
            this.gbx_adresse.Controls.Add(this.tbx_plz);
            this.gbx_adresse.Controls.Add(this.tbx_strasse);
            this.gbx_adresse.Controls.Add(this.lbl_ort);
            this.gbx_adresse.Controls.Add(this.lbl_strasse);
            this.gbx_adresse.Controls.Add(this.lbl_plz);
            this.gbx_adresse.Location = new System.Drawing.Point(16, 57);
            this.gbx_adresse.Name = "gbx_adresse";
            this.gbx_adresse.Size = new System.Drawing.Size(200, 177);
            this.gbx_adresse.TabIndex = 5;
            this.gbx_adresse.TabStop = false;
            this.gbx_adresse.Text = "Adresse";
            // 
            // tbx_ort
            // 
            this.tbx_ort.Location = new System.Drawing.Point(12, 141);
            this.tbx_ort.Name = "tbx_ort";
            this.tbx_ort.Size = new System.Drawing.Size(174, 20);
            this.tbx_ort.TabIndex = 4;
            // 
            // tbx_plz
            // 
            this.tbx_plz.Location = new System.Drawing.Point(9, 91);
            this.tbx_plz.MaxLength = 5;
            this.tbx_plz.Name = "tbx_plz";
            this.tbx_plz.Size = new System.Drawing.Size(68, 20);
            this.tbx_plz.TabIndex = 3;
            this.tbx_plz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_plz_KeyPress);
            // 
            // tbx_strasse
            // 
            this.tbx_strasse.Location = new System.Drawing.Point(9, 42);
            this.tbx_strasse.Name = "tbx_strasse";
            this.tbx_strasse.Size = new System.Drawing.Size(177, 20);
            this.tbx_strasse.TabIndex = 2;
            // 
            // btn_erstellen
            // 
            this.btn_erstellen.Location = new System.Drawing.Point(223, 198);
            this.btn_erstellen.Name = "btn_erstellen";
            this.btn_erstellen.Size = new System.Drawing.Size(78, 35);
            this.btn_erstellen.TabIndex = 6;
            this.btn_erstellen.Text = "Erstellen";
            this.btn_erstellen.UseVisualStyleBackColor = true;
            this.btn_erstellen.Click += new System.EventHandler(this.btn_erstellen_Click);
            // 
            // Neue_Liegenschaft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 253);
            this.Controls.Add(this.btn_erstellen);
            this.Controls.Add(this.gbx_adresse);
            this.Controls.Add(this.tbx_liegenschafts_nr);
            this.Controls.Add(this.lbl_liegenschafts_nr);
            this.Name = "Neue_Liegenschaft";
            this.Text = "Neue_Liegenschaft";
            this.gbx_adresse.ResumeLayout(false);
            this.gbx_adresse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_liegenschafts_nr;
        private System.Windows.Forms.Label lbl_strasse;
        private System.Windows.Forms.Label lbl_plz;
        private System.Windows.Forms.Label lbl_ort;
        private System.Windows.Forms.TextBox tbx_liegenschafts_nr;
        private System.Windows.Forms.GroupBox gbx_adresse;
        private System.Windows.Forms.TextBox tbx_ort;
        private System.Windows.Forms.TextBox tbx_plz;
        private System.Windows.Forms.TextBox tbx_strasse;
        private System.Windows.Forms.Button btn_erstellen;
    }
}