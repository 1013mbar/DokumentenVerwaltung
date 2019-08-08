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
    public partial class Dokument_ändern : Form
    {
        internal PgSqlConnection Verbindung = new PgSqlConnection();
        internal PgSqlDataAdapter da_dok = new PgSqlDataAdapter();
        internal DataTable dok = new DataTable();
        Form1 Hauptfenster;
        string name = "";
        string bemerkung = "";
        int jahr = 0;
        string dokument_typ = "";
        bool datum = false;


        public Dokument_ändern(Form1 aufrufendes_fenster)
        {
            Hauptfenster = aufrufendes_fenster;
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

        private void Dokument_ändern_Load(object sender, EventArgs e)
        {
            lbl_name.Text = Hauptfenster.dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            lbl_format.Text = Hauptfenster.dataGridView1.CurrentRow.Cells["format"].Value.ToString();
            lbl_format2.Text = Hauptfenster.dataGridView1.CurrentRow.Cells["format"].Value.ToString();
            if (Hauptfenster.dataGridView1.CurrentRow.Cells["datum"].Value.ToString().Length > 10)
                lbl_datum.Text = Hauptfenster.dataGridView1.CurrentRow.Cells["datum"].Value.ToString().Substring(0,10);
            else
                lbl_datum.Text = Hauptfenster.dataGridView1.CurrentRow.Cells["datum"].Value.ToString();
            lbl_bemerkung.Text = Hauptfenster.dataGridView1.CurrentRow.Cells["bemerkung"].Value.ToString();
            lbl_jahr.Text = Hauptfenster.dataGridView1.CurrentRow.Cells["jahr"].Value.ToString();
            lbl_dokument_typ.Text = Hauptfenster.dataGridView1.CurrentRow.Cells["dok_typ"].Value.ToString();
            lbl_lieg1.Text = Hauptfenster.dataGridView1.CurrentRow.Cells["liegenschafts_nr"].Value.ToString();
            lbl_lieg2.Text = Hauptfenster.dataGridView1.CurrentRow.Cells["liegenschafts_nr"].Value.ToString();
        }

        private void tbx_name_TextChanged(object sender, EventArgs e)
        {
            name = tbx_name.Text;
        }

        private void dtp_datum_ValueChanged(object sender, EventArgs e)
        {
            datum = true;
        }

        private void tbx_bemerkung_TextChanged(object sender, EventArgs e)
        {
            bemerkung = tbx_bemerkung.Text;
        }


        private void nup_jahr_ValueChanged(object sender, EventArgs e)
        {
            jahr = int.Parse(nup_jahr.Value.ToString());
        }

        private void lbx_dokument_typ_SelectedIndexChanged(object sender, EventArgs e)
        {
            dokument_typ = lbx_dokument_typ.Text;
        }

        private void btn_aendern_Click(object sender, EventArgs e)
        {
            int position = int.Parse(Hauptfenster.dataGridView1.CurrentRow.Cells["Position"].Value.ToString());
            if (name != "")
            {
                name = tbx_name.Text;
                name = ersetzen(name);
                string update_name = "update dokumente set name = '" + name + "' where position = '" + position.ToString() + "'";
                PgSqlCommand cmd_update_name = new PgSqlCommand(update_name, Verbindung);
                cmd_update_name.ExecuteNonQuery();
            }
            if (bemerkung != "")
            {
                bemerkung = tbx_bemerkung.Text;
                bemerkung = ersetzen(bemerkung);
                string update_bemerkung = "update dokumente set bemerkung = '" + bemerkung + "' where position = '" + position.ToString() + "'";
                PgSqlCommand cmd_update_bemerkung = new PgSqlCommand(update_bemerkung, Verbindung);
                cmd_update_bemerkung.ExecuteNonQuery();
            }
            if (dokument_typ != "")
            {
                dokument_typ = lbx_dokument_typ.Text;
                string update_dokument_typ = "update dokumente set dok_typ = '" + dokument_typ + "' where position = '" + position.ToString() + "'";
                PgSqlCommand cmd_update_dok_typ = new PgSqlCommand(update_dokument_typ, Verbindung);
                cmd_update_dok_typ.ExecuteNonQuery();
            }
            if (jahr != 0)
            {
                jahr = int.Parse(nup_jahr.Text);
                string update_jahr = "update dokumente set jahr = '" + jahr + "' where position = '" + position.ToString() + "'";
                PgSqlCommand cmd_update_jahr = new PgSqlCommand(update_jahr, Verbindung);
                cmd_update_jahr.ExecuteNonQuery();
            }
            if (datum == true)
            {
                string date = dtp_datum.Value.Month.ToString() + "/" + dtp_datum.Value.Day.ToString() + "/" + dtp_datum.Value.Year.ToString();
                string update_datum = "update dokumente set datum = '" + date + "' where position = '" + position.ToString() + "'";
                PgSqlCommand cmd_update_datum = new PgSqlCommand(update_datum, Verbindung);
                cmd_update_datum.ExecuteNonQuery();
            }

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

    }
}
