namespace DokumentVerwaltung
{
    partial class Liegenschaft_ändern
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ort = new System.Windows.Forms.Label();
            this.lbl_plz = new System.Windows.Forms.Label();
            this.lbl_strasse = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbx_ort = new System.Windows.Forms.TextBox();
            this.tbx_plz = new System.Windows.Forms.TextBox();
            this.tbx_strasse = new System.Windows.Forms.TextBox();
            this.btn_aendern = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Straße:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PLZ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ort:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_ort);
            this.groupBox1.Controls.Add(this.lbl_plz);
            this.groupBox1.Controls.Add(this.lbl_strasse);
            this.groupBox1.Location = new System.Drawing.Point(120, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 132);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datensatz";
            // 
            // lbl_ort
            // 
            this.lbl_ort.AutoSize = true;
            this.lbl_ort.Location = new System.Drawing.Point(6, 110);
            this.lbl_ort.Name = "lbl_ort";
            this.lbl_ort.Size = new System.Drawing.Size(0, 13);
            this.lbl_ort.TabIndex = 3;
            // 
            // lbl_plz
            // 
            this.lbl_plz.AutoSize = true;
            this.lbl_plz.Location = new System.Drawing.Point(6, 65);
            this.lbl_plz.Name = "lbl_plz";
            this.lbl_plz.Size = new System.Drawing.Size(0, 13);
            this.lbl_plz.TabIndex = 2;
            // 
            // lbl_strasse
            // 
            this.lbl_strasse.AutoSize = true;
            this.lbl_strasse.Location = new System.Drawing.Point(6, 24);
            this.lbl_strasse.Name = "lbl_strasse";
            this.lbl_strasse.Size = new System.Drawing.Size(0, 13);
            this.lbl_strasse.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbx_ort);
            this.groupBox2.Controls.Add(this.tbx_plz);
            this.groupBox2.Controls.Add(this.tbx_strasse);
            this.groupBox2.Location = new System.Drawing.Point(336, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 161);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Neue Daten";
            // 
            // tbx_ort
            // 
            this.tbx_ort.Location = new System.Drawing.Point(7, 106);
            this.tbx_ort.Name = "tbx_ort";
            this.tbx_ort.Size = new System.Drawing.Size(200, 20);
            this.tbx_ort.TabIndex = 2;
            this.tbx_ort.TextChanged += new System.EventHandler(this.tbx_ort_TextChanged);
            // 
            // tbx_plz
            // 
            this.tbx_plz.Location = new System.Drawing.Point(7, 61);
            this.tbx_plz.MaxLength = 5;
            this.tbx_plz.Name = "tbx_plz";
            this.tbx_plz.Size = new System.Drawing.Size(83, 20);
            this.tbx_plz.TabIndex = 1;
            this.tbx_plz.TextChanged += new System.EventHandler(this.tbx_plz_TextChanged);
            this.tbx_plz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_plz_KeyPress);
            // 
            // tbx_strasse
            // 
            this.tbx_strasse.Location = new System.Drawing.Point(7, 20);
            this.tbx_strasse.Name = "tbx_strasse";
            this.tbx_strasse.Size = new System.Drawing.Size(200, 20);
            this.tbx_strasse.TabIndex = 0;
            // 
            // btn_aendern
            // 
            this.btn_aendern.Location = new System.Drawing.Point(120, 151);
            this.btn_aendern.Name = "btn_aendern";
            this.btn_aendern.Size = new System.Drawing.Size(210, 23);
            this.btn_aendern.TabIndex = 6;
            this.btn_aendern.Text = "Ändern";
            this.btn_aendern.UseVisualStyleBackColor = true;
            this.btn_aendern.Click += new System.EventHandler(this.btn_aendern_Click);
            // 
            // Liegenschaft_ändern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 189);
            this.Controls.Add(this.btn_aendern);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Liegenschaft_ändern";
            this.Text = "Liegenschaft_ändern";
            this.Load += new System.EventHandler(this.Liegenschaft_ändern_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_ort;
        private System.Windows.Forms.Label lbl_plz;
        private System.Windows.Forms.Label lbl_strasse;
        private System.Windows.Forms.TextBox tbx_ort;
        private System.Windows.Forms.TextBox tbx_plz;
        private System.Windows.Forms.TextBox tbx_strasse;
        private System.Windows.Forms.Button btn_aendern;
    }
}