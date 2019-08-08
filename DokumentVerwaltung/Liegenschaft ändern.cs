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
    public partial class Liegenschaft_ändern : Form
    {

        internal PgSqlConnection Verbindung = new PgSqlConnection();
        internal PgSqlDataAdapter da_dok = new PgSqlDataAdapter();
        internal PgSqlDataAdapter da_liegenschaften = new PgSqlDataAdapter();
        internal DataTable dok = new DataTable();
        internal DataTable liegenschaften = new DataTable();
        Form1 Hauptfenster;
        string strasse = "";
        int plz = 0;
        string ort = "";

        public Liegenschaft_ändern(Form1 aufrufendes_fenster)
        {
            Hauptfenster = aufrufendes_fenster;
            Verbindung.ConnectionString = "user id = postgres;password = "+ Hauptfenster.pw +";host = "+ Hauptfenster.host +";port = "+ Hauptfenster.port.ToString() +";database = postgres;pooling = true;min pool size = 0;max pool size = 100;connection lifetime = 0;";
            while (Verbindung.State.ToString() == "Closed")
            {
                try
                {
                    Verbindung.Open();
                }
                catch (Exception)
                {
                }
            }
            InitializeComponent();
            this.Text += (":  " + aufrufendes_fenster.dataGridView2.CurrentRow.Cells["liegenschafts_nr"].Value.ToString());
        }
        private void tbx_strasse_TextChanged(object sender, EventArgs e)
        {
            strasse = tbx_strasse.Text;
        }

        private void tbx_plz_TextChanged(object sender, EventArgs e)
        {
            try
            {
                plz = int.Parse(tbx_plz.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Falsche PLZ!");
            }
        }

        private void tbx_ort_TextChanged(object sender, EventArgs e)
        {
            ort = tbx_ort.Text;
        }

        private void Liegenschaft_ändern_Load(object sender, EventArgs e)
        {
            lbl_strasse.Text = Hauptfenster.dataGridView2.CurrentRow.Cells["strasse"].Value.ToString();
            lbl_plz.Text = Hauptfenster.dataGridView2.CurrentRow.Cells["plz"].Value.ToString();
            lbl_ort.Text = Hauptfenster.dataGridView2.CurrentRow.Cells["ort"].Value.ToString();
        }

        private void btn_aendern_Click(object sender, EventArgs e)
        {
            if (lbl_ort.Text != "" && lbl_plz.Text != "" && lbl_strasse.Text != "")
            {
                int position = int.Parse(Hauptfenster.dataGridView2.CurrentRow.Cells["Position"].Value.ToString());
                MessageBox.Show(strasse);
                strasse = ersetzen(strasse);
                ort = ersetzen(ort);
                if (strasse != "")
                {
                    string update_strasse = "update liegenschaften set strasse = '" + strasse + "' where position = '" + position.ToString() + "'";
                    PgSqlCommand cmd_update_strasse = new PgSqlCommand(update_strasse, Verbindung);
                    cmd_update_strasse.ExecuteNonQuery();
                }
                if (plz != 0)
                {
                    string update_plz = "update liegenschaften set plz = '" + plz + "' where position = '" + position.ToString() + "'";
                    PgSqlCommand cmd_update_plz = new PgSqlCommand(update_plz, Verbindung);
                    cmd_update_plz.ExecuteNonQuery();
                }
                if (ort != "")
                {
                    string update_ort = "update liegenschaften set ort = '" + ort + "' where position = '" + position.ToString() + "'";
                    PgSqlCommand cmd_update_ort = new PgSqlCommand(update_ort, Verbindung);
                    cmd_update_ort.ExecuteNonQuery();
                }
            }
            else
                MessageBox.Show("Keine Liegenschaft ausgewählt!");

            this.Close();
        }
        public string ersetzen(string s)
        {
            s = s.Replace("ß", "s%");
            s = s.Replace("Ö", "O%");
            s = s.Replace("ö", "o%");
            s = s.Replace("Ä", "A%");
            s = s.Replace("ä", "a%");
            s = s.Replace("Ü", "U%");
            s = s.Replace("ü", "u%");
            return s;

        }

        private void tbx_plz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true; 
        }
    }
}
