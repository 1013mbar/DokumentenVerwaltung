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
    public partial class Neue_Liegenschaft : Form
    {
        internal PgSqlConnection Verbindung = new PgSqlConnection();
        internal DataTable liegenschaften = new DataTable();

        public Neue_Liegenschaft(Form1 Hauptfenster)
        {
            Verbindung.ConnectionString = "user id = postgres;password = " + Hauptfenster.pw + ";host = " + Hauptfenster.host + ";port = " + Hauptfenster.port.ToString() + ";database = postgres;pooling = true;min pool size = 0;max pool size = 100;connection lifetime = 0;";
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
        }

        private void btn_erstellen_Click(object sender, EventArgs e)
        {
            string liegenschafts_nr = ersetzen(tbx_liegenschafts_nr.Text);
            string ort = ersetzen(tbx_ort.Text);
            string strasse = ersetzen(tbx_strasse.Text);

            try
            {
                if (tbx_liegenschafts_nr.Text == "" || tbx_liegenschafts_nr.Text.Length != 10)
                {
                    MessageBox.Show("Keine oder ungültige Liegenschafts-Nr. angegeben!");
                }

                else
                {
                    if (tbx_plz.Text == "")
                    {
                        string insert = "insert into liegenschaften (liegenschafts_nr, strasse, ort) values ('" + liegenschafts_nr + "','" + strasse + "','" + ort + "')";
                        PgSqlCommand cmd_insert = new PgSqlCommand(insert, Verbindung);
                        cmd_insert.ExecuteNonQuery();
                        this.Close();
                    }

                    else
                    {
                        string insert = "insert into liegenschaften (liegenschafts_nr, strasse, plz, ort) values ('" + liegenschafts_nr + "','" + strasse + "','" + int.Parse(tbx_plz.Text) + "','" + ort + "')";
                        PgSqlCommand cmd_insert = new PgSqlCommand(insert, Verbindung);
                        cmd_insert.ExecuteNonQuery();
                        this.Close();
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Die Liegenschaft ist bereits vorhanden!");
            }
        }
        //prüft ob Sonderzeichen in einem String vorhanden sind
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
          
            if (!char.IsDigit(e.KeyChar ) && !char.IsControl(e.KeyChar)) 
                e.Handled = true; 

        }
    }
}
