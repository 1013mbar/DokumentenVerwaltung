namespace DokumentVerwaltung
{
    partial class Pfade_ändern
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
            this.tbx_tempo_pfad = new System.Windows.Forms.TextBox();
            this.tbx_timer_pfad = new System.Windows.Forms.TextBox();
            this.btn_aendern = new System.Windows.Forms.Button();
            this.btn_exp_tempo = new System.Windows.Forms.Button();
            this.btn_exp_timer = new System.Windows.Forms.Button();
            this.ofd_twain = new System.Windows.Forms.OpenFileDialog();
            this.fbd_tempo = new System.Windows.Forms.FolderBrowserDialog();
            this.fbd_timer = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pfad zum erzeugen von temporären Daten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Timer Pfad";
            // 
            // tbx_tempo_pfad
            // 
            this.tbx_tempo_pfad.Location = new System.Drawing.Point(12, 27);
            this.tbx_tempo_pfad.Name = "tbx_tempo_pfad";
            this.tbx_tempo_pfad.Size = new System.Drawing.Size(263, 20);
            this.tbx_tempo_pfad.TabIndex = 4;
            // 
            // tbx_timer_pfad
            // 
            this.tbx_timer_pfad.Location = new System.Drawing.Point(12, 89);
            this.tbx_timer_pfad.Name = "tbx_timer_pfad";
            this.tbx_timer_pfad.Size = new System.Drawing.Size(263, 20);
            this.tbx_timer_pfad.TabIndex = 5;
            // 
            // btn_aendern
            // 
            this.btn_aendern.Location = new System.Drawing.Point(188, 131);
            this.btn_aendern.Name = "btn_aendern";
            this.btn_aendern.Size = new System.Drawing.Size(75, 40);
            this.btn_aendern.TabIndex = 6;
            this.btn_aendern.Text = "Pfade änden";
            this.btn_aendern.UseVisualStyleBackColor = true;
            this.btn_aendern.Click += new System.EventHandler(this.btn_aendern_Click);
            // 
            // btn_exp_tempo
            // 
            this.btn_exp_tempo.Location = new System.Drawing.Point(282, 25);
            this.btn_exp_tempo.Name = "btn_exp_tempo";
            this.btn_exp_tempo.Size = new System.Drawing.Size(75, 23);
            this.btn_exp_tempo.TabIndex = 8;
            this.btn_exp_tempo.Text = "Explorer";
            this.btn_exp_tempo.UseVisualStyleBackColor = true;
            this.btn_exp_tempo.Click += new System.EventHandler(this.btn_exp_tempo_Click);
            // 
            // btn_exp_timer
            // 
            this.btn_exp_timer.Location = new System.Drawing.Point(282, 87);
            this.btn_exp_timer.Name = "btn_exp_timer";
            this.btn_exp_timer.Size = new System.Drawing.Size(75, 23);
            this.btn_exp_timer.TabIndex = 9;
            this.btn_exp_timer.Text = "Explorer";
            this.btn_exp_timer.UseVisualStyleBackColor = true;
            this.btn_exp_timer.Click += new System.EventHandler(this.btn_exp_timer_Click);
            // 
            // ofd_twain
            // 
            this.ofd_twain.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pfade zurücksetzten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "Abbrechen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pfade_ändern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 183);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_exp_timer);
            this.Controls.Add(this.btn_exp_tempo);
            this.Controls.Add(this.btn_aendern);
            this.Controls.Add(this.tbx_timer_pfad);
            this.Controls.Add(this.tbx_tempo_pfad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Pfade_ändern";
            this.Text = "Pfade_ändern";
            this.Load += new System.EventHandler(this.Pfade_ändern_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_tempo_pfad;
        private System.Windows.Forms.TextBox tbx_timer_pfad;
        private System.Windows.Forms.Button btn_aendern;
        private System.Windows.Forms.Button btn_exp_tempo;
        private System.Windows.Forms.Button btn_exp_timer;
        private System.Windows.Forms.OpenFileDialog ofd_twain;
        private System.Windows.Forms.FolderBrowserDialog fbd_tempo;
        private System.Windows.Forms.FolderBrowserDialog fbd_timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}