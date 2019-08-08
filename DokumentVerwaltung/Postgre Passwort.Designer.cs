namespace DokumentVerwaltung
{
    partial class Postgre_Passwort
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cbx_host = new System.Windows.Forms.CheckBox();
            this.cbx_port = new System.Windows.Forms.CheckBox();
            this.tbx_host = new System.Windows.Forms.TextBox();
            this.tbx_port = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bestätigen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bitte geben sie ihr Passwort für die PostgreSQL Datenbank ein:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Erster Programmstart?";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Nein";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbx_host
            // 
            this.cbx_host.AutoSize = true;
            this.cbx_host.Location = new System.Drawing.Point(15, 64);
            this.cbx_host.Name = "cbx_host";
            this.cbx_host.Size = new System.Drawing.Size(51, 17);
            this.cbx_host.TabIndex = 7;
            this.cbx_host.Text = "Host:";
            this.cbx_host.UseVisualStyleBackColor = true;
            this.cbx_host.CheckedChanged += new System.EventHandler(this.cbx_host_CheckedChanged);
            // 
            // cbx_port
            // 
            this.cbx_port.AutoSize = true;
            this.cbx_port.Location = new System.Drawing.Point(192, 64);
            this.cbx_port.Name = "cbx_port";
            this.cbx_port.Size = new System.Drawing.Size(48, 17);
            this.cbx_port.TabIndex = 8;
            this.cbx_port.Text = "Port:";
            this.cbx_port.UseVisualStyleBackColor = true;
            this.cbx_port.CheckedChanged += new System.EventHandler(this.cbx_port_CheckedChanged);
            // 
            // tbx_host
            // 
            this.tbx_host.Enabled = false;
            this.tbx_host.Location = new System.Drawing.Point(15, 87);
            this.tbx_host.Name = "tbx_host";
            this.tbx_host.Size = new System.Drawing.Size(119, 20);
            this.tbx_host.TabIndex = 9;
            // 
            // tbx_port
            // 
            this.tbx_port.Enabled = false;
            this.tbx_port.Location = new System.Drawing.Point(192, 87);
            this.tbx_port.Name = "tbx_port";
            this.tbx_port.Size = new System.Drawing.Size(92, 20);
            this.tbx_port.TabIndex = 10;
            // 
            // Postgre_Passwort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 158);
            this.Controls.Add(this.tbx_port);
            this.Controls.Add(this.tbx_host);
            this.Controls.Add(this.cbx_port);
            this.Controls.Add(this.cbx_host);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Postgre_Passwort";
            this.Text = "Postgre Einstellungen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Postgre_Passwort_FormClosed);
            this.Load += new System.EventHandler(this.Postgre_Passwort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cbx_host;
        private System.Windows.Forms.CheckBox cbx_port;
        private System.Windows.Forms.TextBox tbx_host;
        private System.Windows.Forms.TextBox tbx_port;
    }
}