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
    public partial class Neues_Dokument : Form
    {
        internal PgSqlConnection Verbindung = new PgSqlConnection();
        internal PgSqlDataAdapter da_dok = new PgSqlDataAdapter();
        internal DataTable dok = new DataTable();
        internal BindingSource bindingSource1 = new BindingSource();
        Form1 Hauptfenster;
        string liegenschaft = "";

        public Neues_Dokument(Form1 aufrufendes_fenster)
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
            liegenschaft = Hauptfenster.dataGridView2.CurrentRow.Cells["liegenschafts_nr"].Value.ToString();
        }

        private void btn_einfuegen_Click(object sender, EventArgs e)
        {
            if (tbx_datenpfad.Text != "" && tbx_name.Text != "")
            {
                string name = ersetzen(tbx_name.Text);
                string bemerkung = ersetzen(tbx_bemerkung.Text);
                //Datei wird eingelesen
                FileInfo fi = new FileInfo(tbx_datenpfad.Text);
                FileStream fs = fi.OpenRead();
                byte[] buffer = new Byte[fi.Length];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();
                string datei = Convert.ToBase64String(buffer);
                string format = tbx_datenpfad.Text.Substring(tbx_datenpfad.Text.Length - 3);
                string date = dtp_datum.Value.Month.ToString() + "/" + dtp_datum.Value.Day.ToString() +"/"+ dtp_datum.Value.Year.ToString();
                string insert = "insert into dokumente (name, string, format, datum, bemerkung, liegenschafts_nr, jahr, dok_typ) values ('" + name + "', '" + datei + "', '" + format + "', '" + date + "', '" + bemerkung + "', '" + liegenschaft + "', '" + int.Parse(Hauptfenster.nud_jahr.Value.ToString()) + "', '" + lbx_dokument_typ.Text + "' )";
                PgSqlCommand cmd_insert = new PgSqlCommand(insert, Verbindung);
                cmd_insert.ExecuteNonQuery();
                this.Close();
            }

            else
            {
                if (tbx_datenpfad.Text == "")
                    MessageBox.Show("Bitte geben sie einen Datenpfad an!");
                if (tbx_name.Text == "")
                    MessageBox.Show("Bitte geben sie einen Namen an!");
            }
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            tbx_datenpfad.Text = openFileDialog1.FileName;
        }

        private void Neues_Dokument_Load(object sender, EventArgs e)
        {
            lbl_liegenschafts_nr.Text = liegenschaft;
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
