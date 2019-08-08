using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using System.IO;

namespace DokumentVerwaltung
{
    public partial class Postgre_Passwort : Form
    {
        Form1 HF;
        public bool eins = true;
        public bool userCLosePG = false;
        PgSqlConnection Verbindung2 = new PgSqlConnection();
        public Postgre_Passwort(Form1 Hauptfenster, bool erster_start)
        {
            InitializeComponent();
            HF = Hauptfenster;
            button1.Enabled = false;
            if (!erster_start)
            {
                label3.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userCLosePG = true;
            if (textBox1.Text != "")
            {
                HF.pw = textBox1.Text;
                HF.WriteLine(HF.txt_pfad, 1, textBox1.Text);
            }
            
            if (cbx_port.Checked && tbx_port.Text == "")
                MessageBox.Show("Es wurde kein Port angegeben!");
            else if (cbx_port.Checked && tbx_port.Text != "")
            {
                HF.port = tbx_port.Text;
                HF.WriteLine(HF.txt_pfad, 5, tbx_port.Text);
            }
            if (cbx_host.Checked && tbx_host.Text == "")
                MessageBox.Show("Es wurde kein Host angegeben!");
            else if (cbx_host.Checked && tbx_host.Text != "")
            {
                HF.host = tbx_host.Text;
                HF.WriteLine(HF.txt_pfad, 4, tbx_host.Text);
            }
            if (eins && tbx_port.Text != "" && tbx_host.Text != "" && textBox1.Text != "")
            {
                try
                {
                    Verbindung2.ConnectionString = "user id = postgres;password = " + textBox1.Text + ";host = " + tbx_host.Text + ";port = " + tbx_port.Text + ";database = postgres;pooling = true;min pool size = 0;max pool size = 100;connection lifetime = 0;";
                    Verbindung2.Open();
                    string neue_tabelle = "CREATE TABLE liegenschaften (liegenschafts_nr text primary key, strasse text, plz int, ort text)";
                    PgSqlCommand cmd_erzeuge = new PgSqlCommand(neue_tabelle, Verbindung2);
                    cmd_erzeuge.ExecuteNonQuery();
                    string dokumente = "CREATE TABLE dokumente (position serial primary key, name text, string text, format text, datum date, bemerkung text, liegenschafts_nr text, jahr int, dok_typ text)";
                    PgSqlCommand cmd_erzeuge2 = new PgSqlCommand(dokumente, Verbindung2);
                    cmd_erzeuge2.ExecuteNonQuery();
                    Verbindung2.Close();
                }
                catch (Exception ex)
                {
                }

            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eins = true;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eins = false;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void tbx_plz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbx_host_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_host.Checked)
                tbx_host.Enabled = true;
            else
                tbx_host.Enabled = false;
        }

        private void cbx_port_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_port.Checked)
                tbx_port.Enabled = true;
            else
                tbx_port.Enabled = false;
        }

        private void Postgre_Passwort_Load(object sender, EventArgs e)
        {
            textBox1.Text = HF.pw;
            tbx_host.Text = HF.host;
            tbx_port.Text = HF.port;
        }

        private void Postgre_Passwort_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!userCLosePG)
                HF.userClose = false;
        }
    }
}
