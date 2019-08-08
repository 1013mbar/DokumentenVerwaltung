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
    public partial class Form1 : Form
    {
        //Deklaration von DataAdaptern, DataTabeles etc...
        internal PgSqlConnection Verbindung = new PgSqlConnection();
        internal PgSqlDataAdapter da_dok = new PgSqlDataAdapter();
        internal PgSqlDataAdapter da_liegenschaften = new PgSqlDataAdapter();
        internal DataTable dok = new DataTable();
        internal DataTable liegenschaften = new DataTable();
        internal DataTable dbf_tabelle = new DataTable();
        public string filter_liegenschafts_nr = "";
        public string tempo_pfad = "";
        public string timer_pfad = "";
        public string pw = "";
        public string host = "";
        public string port = "";
        public bool pwbool = false;
        public bool userClose = true;
        public string txt_pfad = "";
        public bool timer = false;
        public int start = 0;
        
        public Form1()
        {

            if (!System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dokument_Verwaltung"))
            {

                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dokument_Verwaltung");
                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dokument_Verwaltung\tempo");
                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dokument_Verwaltung\timer");
                var myFile = File.Create((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dokument_Verwaltung\info.txt"));
                myFile.Close();
                tempo_pfad = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dokument_Verwaltung\tempo";
                timer_pfad = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dokument_Verwaltung\timer";
                WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dokument_Verwaltung\info.txt", 2, tempo_pfad);
                WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dokument_Verwaltung\info.txt", 3, timer_pfad);


            }

            txt_pfad = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dokument_Verwaltung\info.txt";
            if (pfadevorhanden(txt_pfad))
            {
                pw = ReadLine(txt_pfad, 1);
                host = ReadLine(txt_pfad, 4);
                port = ReadLine(txt_pfad, 5);
                tempo_pfad = ReadLine(txt_pfad, 2);
                timer_pfad = ReadLine(txt_pfad, 3);
            }
            else
            {
                Postgre_Passwort ppw = new Postgre_Passwort(this, true);
                ppw.ShowDialog();
            }
            while (!pwbool && userClose)
            {
                while (Verbindung.State.ToString() == "Closed")
                {
                    try
                    {
                        Verbindung.ConnectionString = "user id = postgres;password = " + pw + ";host = " + host + ";port = " + port.ToString() + ";database = postgres;pooling = true;min pool size = 0;max pool size = 100;connection lifetime = 0;";
                        Verbindung.Open();
                        pwbool = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Es konnte nicht auf die Datenbank zugegriffen werden." + ex.ToString());
                        //Postgre_Passwort ppw = new Postgre_Passwort(this, true);
                        //ppw.ShowDialog();
                    }
                }
            }
            InitializeComponent();
            DateTime cur = DateTime.Now;
            int curYear = cur.Year;
            nud_jahr.Value = curYear;
            start++;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] pfade = Directory.GetFiles(tempo_pfad);
                foreach (string s in pfade)
                {
                    System.IO.File.Delete(s);
                }
            }
            catch (Exception)
            {
            }
            if (!userClose)
            {
                //MessageBox.Show("Hey");
                this.Close();
            }
            else
            {
                //MessageBox.Show("1");
                akt_liegenschaften();
                //MessageBox.Show("2");
                akt_dok();
                MessageBox.Show(dataGridView1.Columns.Count.ToString());
                
                
                //dataGridView1.Columns["string"].Visible = false;
                dataGridView1.Columns["position"].Visible = false;
                dataGridView1.Columns["liegenschafts_nr"].Visible = false;
                dataGridView1.Columns["name"].HeaderText = "Dokument-Name";
                dataGridView1.Columns["dok_typ"].HeaderText = "Dokument-Typ";
                dataGridView1.Columns["jahr"].HeaderText = "Jahr";
                dataGridView1.Columns["bemerkung"].HeaderText = "Bemerkung";
                dataGridView1.Columns["datum"].HeaderText = "Datum";
                dataGridView1.Columns["format"].HeaderText = "Format";
                dataGridView1.Columns["format"].Visible = false;
                dataGridView2.Columns["liegenschafts_nr"].HeaderText = "Liegenschafts-Nr";
                dataGridView2.Columns["strasse"].HeaderText = "Straße";
                dataGridView2.Columns["ort"].HeaderText = "Ort";
                dataGridView2.Columns["plz"].HeaderText = "PLZ";
                //MessageBox.Show("Hey3");
                if (pfadevorhanden(txt_pfad))
                {
                    tempo_pfad = ReadLine(txt_pfad, 2);
                    timer_pfad = ReadLine(txt_pfad, 3);
                }
                try
                {
         
                    lbl_aktuelle_liegenschaft.Text = dataGridView2.CurrentRow.Cells["liegenschafts_nr"].Value.ToString();
                    string liegenschafts_nr = dataGridView2.CurrentRow.Cells["liegenschafts_nr"].Value.ToString();
                    dok.Clear();
                    //string select = "select * from dokumente where liegenschafts_nr = '" + liegenschafts_nr + "'";
                    string select = "select position, name, datum, jahr, dok_typ, bemerkung from dokumente where liegenschafts_nr = '" + liegenschafts_nr + "'";
                    PgSqlCommand cmd_select = new PgSqlCommand(select, Verbindung);
                    da_dok.SelectCommand = cmd_select;
                    da_dok.Fill(dok);
                    lbl_aktuelle_liegenschaft.Text = dataGridView2.CurrentRow.Cells["liegenschafts_nr"].Value.ToString();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                liegenschaften_ueberfuehren();
                zeichen_ersetzen();
                //timer1.Interval = 10000;
                //timer1.Start();
                //lbl_timer.Text = "Timer ist an";
                
            }
        }

        //Lädt alle vorhandenen Datensätze aus dokumente in den DataTable Dokumente und zeigt diese im DGV an
        private void akt_dok()
        {
            dok.Clear();
            //string select = "select * from dokumente";
            string select = "select position, name, datum, liegenschafts_nr, jahr, dok_typ, bemerkung from dokumente";
            PgSqlCommand cmd_select = new PgSqlCommand(select, Verbindung);
            da_dok.SelectCommand = cmd_select;
            da_dok.Fill(dok);
            dataGridView1.DataSource = dok;
            zeichen_ersetzen();
 
        }

        //Lädt alle vorhandenen Datensätze aus dokumenteliegenschaften in den DataTable liegenschaften und zeigt diese im DGV an
        private void akt_liegenschaften()
        {
            liegenschaften.Clear();
            string select = "select * from liegenschaften";
            PgSqlCommand cmd_select = new PgSqlCommand(select, Verbindung);
            da_liegenschaften.SelectCommand = cmd_select;
            da_liegenschaften.Fill(liegenschaften);
            dataGridView2.DataSource = liegenschaften;
            zeichen_ersetzen();
        }


        private void dok_neu_Click(object sender, EventArgs e)
        {
            //Es wird überprüft ob eine Liegenschaft ausgewählt ist
            if (lbl_aktuelle_liegenschaft.Text != "")
            {
                try
                {
                    string liegenschaft = dataGridView2.CurrentRow.Cells["liegenschafts_nr"].Value.ToString();
                    Neues_Dokument neu = new Neues_Dokument(this);
                    neu.ShowDialog();
                    dokument_auswahl();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Keine Liegenschaft ausgewählt!" + ex.ToString());
                }
            }

            else
                MessageBox.Show("Keine Liegenschaft ausgewählt!");
        }

        private void btn_alle_Click(object sender, EventArgs e)
        {
            //dokument_auswahl();
            dok.Clear();
            string sel = "select * from dokumente";
            PgSqlCommand selAll = new PgSqlCommand(sel, Verbindung);
            da_dok.SelectCommand = selAll;
            da_dok.Fill(dok);
            lbl_aktuelle_liegenschaft.Text = "";
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //Das im DGV ausgewählte Dokument wird ausgelesen und mit einem passenden Programm angezeigt
            try
            {

                string name = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                string format = dataGridView1.CurrentRow.Cells["format"].Value.ToString();
                int dok_id = int.Parse(dataGridView1.CurrentRow.Cells["Position"].Value.ToString());
                string pfad_voll = tempo_pfad + @"\" + dok_id + "." + format;
                if (!System.IO.File.Exists(pfad_voll))
                {
                    string getData = "select string from dokumente where Position = " + dok_id + " ";
                    PgSqlCommand cmd_getData = new PgSqlCommand(getData, Verbindung);
                    PgSqlDataReader rdr = cmd_getData.ExecuteReader();
                    if (System.IO.File.Exists(pfad_voll))
                    {
                        System.IO.File.Delete(pfad_voll);
                    }
                    while (rdr.Read())
                    {
                        byte[] data = Convert.FromBase64String(rdr[0].ToString());
                        FileStream neu = new FileStream(pfad_voll, FileMode.Create);
                        neu.Write(data, 0, data.Length);
                        neu.Close();
                    }

                    rdr.Close();
                }
                format = format.ToLower();
                //MessageBox.Show(name);
                System.Diagnostics.Process.Start(pfad_voll);
            }
            catch (Exception)
            {
            }
            dokument_auswahl();


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Alle dem angegebenen Verzeichniss enthaltenen Dateien werden gelöscht
            try
            {
                string[] pfade = Directory.GetFiles(tempo_pfad);
                foreach (string s in pfade)
                {
                    System.IO.File.Delete(s);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btn_neu_liegenschaft_Click(object sender, EventArgs e)
        {
            Neue_Liegenschaft neu = new Neue_Liegenschaft(this);
            neu.ShowDialog();
            zeichen_ersetzen();
            akt_liegenschaften();
        }


        private void nud_jahr_ValueChanged(object sender, EventArgs e)
        {
            //wenn cbx_dok_typ nicht aktiviert ist werden im DGV1 die nach jahr und liegenschafts Nr gefilterten Dokumente angezeigt
            if (cbx_dok_typ.Checked == false)
            {
                try
                {
                    dok.Clear();
                    string select = "select * from dokumente where (jahr, liegenschafts_nr) = ('" + (int)nud_jahr.Value + "', '" + dataGridView2.CurrentRow.Cells["liegenschafts_nr"].Value.ToString() + "')";
                    PgSqlCommand cmd_select = new PgSqlCommand(select, Verbindung);
                    da_dok.SelectCommand = cmd_select;
                    da_dok.Fill(dok);
                }
                catch (Exception)
                {
                    if(start > 1)
                        MessageBox.Show("Bitte die dazugehörige Liegenschaft auswählen!");
                }
            }
            //wenn cbx_dok_typ aktiviert ist werden im DGV1 die nach jahr, liegenschafts Nr und dok_typ gefilterten Dokumente angezeigt
            else
            {
                try
                {
                    dok.Clear();
                    string select = "select * from dokumente where (jahr, liegenschafts_nr,dok_typ) = ('" + (int)nud_jahr.Value + "', '" + dataGridView2.CurrentRow.Cells["liegenschafts_nr"].Value.ToString() + "', '" + lbx_filter_dok_typ.Text + "')";
                    PgSqlCommand cmd_select = new PgSqlCommand(select, Verbindung);
                    da_dok.SelectCommand = cmd_select;
                    da_dok.Fill(dok);
                }
                catch (Exception)
                {
                    if (start > 1)
                        MessageBox.Show("Bitte die dazugehörige Liegenschaft auswählen!");
                }
            }
            zeichen_ersetzen();
        }

        private void dok_aendern_Click(object sender, EventArgs e)
        {
            Dokument_ändern aendern = new Dokument_ändern(this);
            aendern.ShowDialog();
            dokument_auswahl();
        }

        private void dok_loeschen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dokument endgültig löschen?", "Löschen", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            try
            {
                string delete = "delete from dokumente where Position = '" + int.Parse(dataGridView1.CurrentRow.Cells["Position"].Value.ToString()) + "'";
                PgSqlCommand cmd_delete = new PgSqlCommand(delete, Verbindung);
                cmd_delete.ExecuteNonQuery();
                dokument_auswahl();
            }
            catch (Exception)
            {
            }
        }

        private void btn_bemerkung_Click(object sender, EventArgs e)
        {
            if(lbl_aktuelle_liegenschaft.Text != "")
                MessageBox.Show(dataGridView1.CurrentRow.Cells["bemerkung"].Value.ToString());
        }

        private void btn_liegenschaft_aendern_Click(object sender, EventArgs e)
        {
            Liegenschaft_ändern aendern = new Liegenschaft_ändern(this);
            aendern.ShowDialog();
            akt_liegenschaften();

        }

        private void btn_liegenschaft_loeschen_Click(object sender, EventArgs e)
        {
            try
            {
                string lgnr = dataGridView2.CurrentRow.Cells["Liegenschafts_nr"].Value.ToString();
                string delete = "delete from liegenschaften where liegenschafts_nr = '" + lgnr + "'";
                PgSqlCommand cmd_delete = new PgSqlCommand(delete, Verbindung);
                cmd_delete.ExecuteNonQuery();
                akt_liegenschaften();
                string delete_dok = "delete from dokumente where liegenschafts_nr = '" + lgnr + "'";
                PgSqlCommand cmd_delete_dok = new PgSqlCommand(delete_dok, Verbindung);
                cmd_delete_dok.ExecuteNonQuery();
                dokument_auswahl();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void btn_scannen_Click(object sender, EventArgs e)
        {
            string[] a = System.IO.Directory.GetFiles(tempo_pfad);
            for (int i = 0; i < a.Length; i++)
            {
                try
                {
                    System.IO.File.Delete(a[i]);
                }
                catch (Exception)
                {
                }
            }

            try
            {
                string liegenschafts_nr = dataGridView2.CurrentRow.Cells["liegenschafts_nr"].Value.ToString();
                Neues_Dokument_scannen nds = new Neues_Dokument_scannen(this);
                nds.ShowDialog();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Keine Liegenschaften ausgewählt!");
            }
            dokument_auswahl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            akt_liegenschaften();
        }

        private void cbx_dok_typ_CheckedChanged(object sender, EventArgs e)
        {
            //falls die cbx true ist, werden die dokumente nach jahr, liegenschafts_nr und dokument typ gefiltert
            if (cbx_dok_typ.Checked == true)
            {
                lbx_filter_dok_typ.Enabled = true;
                try
                {
                    dok.Clear();
                    string select = "select * from dokumente where (jahr, liegenschafts_nr,dok_typ) = ('" + (int)nud_jahr.Value + "', '" + dataGridView2.CurrentRow.Cells["liegenschafts_nr"].Value.ToString() + "', '" + lbx_filter_dok_typ.Text + "')";
                    PgSqlCommand cmd_select = new PgSqlCommand(select, Verbindung);
                    da_dok.SelectCommand = cmd_select;
                    da_dok.Fill(dok);
                }
                catch (Exception)
                {
                    throw;
                }

            }
            //falls die cbx false ist, werden die dokumente nach jahr und liegenschafts_nr gefiltert
            else
            {
                lbx_filter_dok_typ.Enabled = false;
                try
                {
                    dok.Clear();
                    string select = "select * from dokumente where (jahr, liegenschafts_nr) = ('" + (int)nud_jahr.Value + "', '" + dataGridView2.CurrentRow.Cells["liegenschafts_nr"].Value.ToString() + "')";
                    PgSqlCommand cmd_select = new PgSqlCommand(select, Verbindung);
                    da_dok.SelectCommand = cmd_select;
                    da_dok.Fill(dok);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            zeichen_ersetzen();
        }

        private void lbx_filter_dok_typ_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dok.Clear();
                string select = "select * from dokumente where (jahr, liegenschafts_nr,dok_typ) = ('" + (int)nud_jahr.Value + "', '" + dataGridView2.CurrentRow.Cells["liegenschafts_nr"].Value.ToString() + "', '" + lbx_filter_dok_typ.Text + "')";
                PgSqlCommand cmd_select = new PgSqlCommand(select, Verbindung);
                da_dok.SelectCommand = cmd_select;
                da_dok.Fill(dok);
            }
            catch (Exception)
            {
                if(start > 1)
                    MessageBox.Show("Bitte die dazugehörige Liegenschaft auswählen!");
            }
            zeichen_ersetzen();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_liegenschafts_filter.Text = dataGridView2.CurrentCell.OwningColumn.HeaderText;
            lbl_aktuelle_liegenschaft.Text = dataGridView2.CurrentRow.Cells["liegenschafts_nr"].Value.ToString();
            tbx_alt_lg.Text = dataGridView2.CurrentRow.Cells["liegenschafts_nr"].Value.ToString();
            dokument_auswahl((int)nud_jahr.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
                textBox1.Text = textBox1.Text.ToUpper();
            if (lbl_liegenschafts_filter.Text == "plz")
            {
                try
                {
                    int i = int.Parse(textBox1.Text);
                    liegenschaften.Clear();
                    string select = "SELECT * FROM liegenschaften WHERE " + lbl_liegenschafts_filter.Text + " LIKE '" + textBox1.Text + "%'";
                    PgSqlCommand cmd_select = new PgSqlCommand(select, Verbindung);
                    da_liegenschaften.SelectCommand = cmd_select;
                    da_liegenschaften.Fill(liegenschaften);
                    dataGridView2.DataSource = liegenschaften;
                }
                catch (Exception)
                {

                    MessageBox.Show("Falsches Format für eine PLZ!");
                }
            }
            else if (lbl_liegenschafts_filter.Text != "")
            {
                liegenschaften.Clear();
                string select = "";
                if(lbl_liegenschafts_filter.Text == "Liegenschafts-Nr")
                    select = "SELECT * FROM liegenschaften WHERE liegenschafts_nr LIKE '" + textBox1.Text + "%'";
                else
                    select = "SELECT * FROM liegenschaften WHERE " + lbl_liegenschafts_filter.Text + " LIKE '" + textBox1.Text + "%'";
                PgSqlCommand cmd_select = new PgSqlCommand(select, Verbindung);
                da_liegenschaften.SelectCommand = cmd_select;
                da_liegenschaften.Fill(liegenschaften);
                dataGridView2.DataSource = liegenschaften;
            }

            else
                MessageBox.Show("Kein Feld ausgewählt!");
            zeichen_ersetzen();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                string[] a = System.IO.Directory.GetFiles(timer_pfad);
                int i = 0;
                try
                {
                    for (i = 0; i < a.Length; i++)
                    {
                        string pfad = a[i];
                        FileInfo fi = new FileInfo(pfad);
                        FileStream fs = fi.OpenRead();
                        byte[] buffer = new Byte[fi.Length];
                        fs.Read(buffer, 0, buffer.Length);
                        fs.Close();
                        string content = Convert.ToBase64String(buffer);
                        string[] datei = pfad.Split(new Char[] { '_' });
                        string format = datei[datei.Length - 1].Substring(datei[datei.Length - 1].Length - 3, 3);
                        string name = datei[datei.Length - 1].Substring(0, datei[datei.Length - 1].Length - 4);
                        string liegenschaftNr = datei[datei.Length - 3].Substring(datei[datei.Length - 3].Length - 10, 10);
                        //string datum_str = datei[datei.Length - 3];
                        //string day = datum_str.Substring(0, 2);
                        //string month = datum_str.Substring(2, 2);
                        //string year = datum_str.Substring(4, 4);
                        //datum_str = month + "/" + day + "/" + year;
                        //string jahr = datei[datei.Length - 4];
                        string typ_abk = datei[datei.Length - 2];
                        typ_abk = typ_abk.ToLower();
                        string typ = "";
                        switch (typ_abk)
                        {
                            case "abr":
                                typ = "Abrechnungen";
                                break;
                            case "abl":
                                typ = "Ablesungsbelege";
                                break;
                            case "kol":
                                typ = "Kostenbelege";
                                break;
                            case "sch":
                                typ = "Schriftverkehr";
                                break;
                            case "son":
                                typ = "Sonstiges";
                                break;
                            case "leg":
                                typ = "Legionellen";
                                break;
                            case "ren":
                                typ = "Rechnungen";
                                break;
                            case "ver":
                                typ = "Verträge";
                                break;
                            case "ter":
                                typ = "Termine";
                                break;
                            case "kbl":
                                typ = "Kundenbelege";
                                break;
                            case "ted":
                                typ = "Technische Dokumente";
                                break;
                            case "eaw":
                                typ = "Energieausweise";
                                break;
                            case "meg":
                                typ = "MEG";
                                break;
                            default:
                                typ = "Keine Angaben";
                                break;

                        }
                        string insert = "insert into Dokumente (name, string, format, Liegenschafts_nr, dok_typ) values ('" + name + "', '" + content + "', '" + format + "', '" + liegenschaftNr + "', '" + typ + "')";
                        PgSqlCommand cmd = new PgSqlCommand(insert, Verbindung);
                        cmd.ExecuteNonQuery();
                        System.IO.File.Delete(a[i]);
                        dokument_auswahl();
                    }

                }

                catch (Exception exc)
                {
                    try
                    {
                        System.IO.File.Delete(a[i]);
                        MessageBox.Show(exc.ToString());
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString() + "\n" + exc.ToString());
                    }

                }
            }
            catch (Exception)
            {
            }
           
        }

        private void atomatischesEinlesenVonDatenAktivierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10000;
            timer1.Start();
            lbl_timer.Text = "Timer ist an";
        }

        private void automatischesEinlesenVonDatenDeaktivierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lbl_timer.Text = "Timer ist aus";
        }

        public void zeichen_ersetzen()
        {
            //Zählen wieviele Daten ersetzt werden
            MessageBox.Show("Reihen: " + dataGridView2.Rows.Count.ToString() + "Spalten: " + dataGridView2.Columns.Count.ToString());
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                //if(i%100 == 0)
                    //MessageBox.Show(i.ToString());
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    try
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString() != "")
                        {
                            string s = dataGridView2.Rows[i].Cells[j].Value.ToString();
                            s = s.Replace("s%", "ß");
                            //s = s.Replace("?", "ß");
                            s = s.Replace("O%", "Ö");
                            s = s.Replace("o%", "ö");
                            s = s.Replace("A%", "Ä");
                            s = s.Replace("a%", "ä");
                            s = s.Replace("U%", "Ü");
                            s = s.Replace("u%", "ü");
                            dataGridView2.Rows[i].Cells[j].Value = s;
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.ToString());
                    }

                }
            }
            MessageBox.Show("Reihen: " + dataGridView1.Rows.Count.ToString() + "Spalten: " + dataGridView1.Columns.Count.ToString() + "Hallo");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //MessageBox.Show(i.ToString());
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    try
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString() != "")
                        {
                            string s = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            s = s.Replace("s%", "ß");
                            s = s.Replace("O%", "Ö");
                            s = s.Replace("o%", "ö");
                            s = s.Replace("A%", "Ä");
                            s = s.Replace("a%", "ä");
                            s = s.Replace("U%", "Ü");
                            s = s.Replace("u%", "ü");
                            dataGridView1.Rows[i].Cells[j].Value = s;
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.ToString());
                    }
                   
                }
            }
            //MessageBox.Show("Fertig");
        }

        public void dokument_auswahl()
        {
            try
            {
                if (lbl_aktuelle_liegenschaft.Text != "")
                {
                    string liegenschafts_nr = lbl_aktuelle_liegenschaft.Text;
                    dok.Clear();
                    string select = "select position, name, datum, jahr, dok_typ, bemerkung from dokumente where liegenschafts_nr = '" + liegenschafts_nr + "'";
                    PgSqlCommand cmd_select = new PgSqlCommand(select, Verbindung);
                    da_dok.SelectCommand = cmd_select;
                    da_dok.Fill(dok);
                    zeichen_ersetzen();
                }
            }
            catch (Exception)
            {
            }
        }

        public void dokument_auswahl(int jahr)
        {
            try
            {
                if (lbl_aktuelle_liegenschaft.Text != "")
                {
                    string liegenschafts_nr = lbl_aktuelle_liegenschaft.Text;
                    dok.Clear();
                    string select = "select position, name, datum, jahr, dok_typ, bemerkung from dokumente where liegenschafts_nr = '" + liegenschafts_nr + "' and jahr = '" + jahr + "'";
                    PgSqlCommand cmd_select = new PgSqlCommand(select, Verbindung);
                    da_dok.SelectCommand = cmd_select;
                    da_dok.Fill(dok);
                    zeichen_ersetzen();
                }
            }
            catch (Exception)
            {
            }
        }
        private void postgreEinstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Postgre_Passwort ppw = new Postgre_Passwort(this, false);
            ppw.ShowDialog();
            Verbindung.Close();
            Verbindung.ConnectionString = "user id = postgres;password = " + pw + ";host = " + host + ";port = " + port.ToString() + ";database = postgres;pooling = true;min pool size = 0;max pool size = 100;connection lifetime = 0;";
            Verbindung.Open();
            akt_liegenschaften();
            akt_dok();
        }

        public string ReadLine(String sFilename, int iLine)
        {
            string sContent = "";
            float fRow = 0;
            if (File.Exists(sFilename))
            {
                StreamReader myFile = new StreamReader(sFilename, System.Text.Encoding.UTF8);
                while (!myFile.EndOfStream && fRow < iLine)
                {
                    fRow++;
                    sContent = myFile.ReadLine();
                }
                myFile.Close();
                if (fRow < iLine)
                    sContent = "";
            }
            return sContent;
        }

        public void WriteLine(String filename, int lineNumber, string text)
        {
            string sContent = "";
            string[] delimiterstring = { "\r\n" };

            if (File.Exists(filename))
            {
                StreamReader myFile = new StreamReader(filename, System.Text.Encoding.UTF8);
                sContent = myFile.ReadToEnd();
                myFile.Close();
            }

            string[] sCols = sContent.Split(delimiterstring, StringSplitOptions.None);

            if (sCols.Length >= lineNumber)
            {
                sCols[lineNumber - 1] = text;

                sContent = "";
                for (int x = 0; x < sCols.Length - 1; x++)
                {
                    sContent += sCols[x] + "\r\n";
                }
                sContent += sCols[sCols.Length - 1];

            }
            else
            {
                for (int x = 0; x < lineNumber - sCols.Length; x++)
                    sContent += "\r\n";

                sContent += text;
            }


            StreamWriter mySaveFile = new StreamWriter(filename);
            mySaveFile.Write(sContent);
            mySaveFile.Close();

        }

        public bool isEmpty(string filename)
        {
            StreamReader myStr = new StreamReader(filename, Encoding.UTF8);
            string cont = myStr.ReadToEnd();
            myStr.Close();
            if (cont == "")
                return true;
            return false;
        }

        public bool pfadevorhanden(string filename)
        {
            string[] delimiterstring = { "\r\n" };
            StreamReader myStr = new StreamReader(filename, Encoding.UTF8);
            string cont = myStr.ReadToEnd();
            myStr.Close();
            string[] contArray = cont.Split(delimiterstring, StringSplitOptions.None);
            if (contArray.Length == 5)
                return true;
            return false;
        }

        private void liegenschaftenÜberführenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            #region dbf to dt
            //folderBrowserDialog1.ShowDialog();
            //try
            //{
            //    string dbf_pfad = folderBrowserDialog1.SelectedPath.ToString() + @"\objekt1.dbf";
            //    int strasse = 0;
            //    int plz = 0;
            //    int ort = 0;
            //    string strasse_str = "";
            //    string ort_str = "";
            //    string plz_str = "";
            //    bool b_strasse = false;
            //    bool b_ort = false;
            //    bool b_plz = false;

            //    dbf_tabelle = ParseDBF.ReadDBF(dbf_pfad);
            //    for (int i = 0; i < dbf_tabelle.Columns.Count; i++)
            //    {
            //        if (dbf_tabelle.Columns[i].ColumnName == "STRASSE" || dbf_tabelle.Columns[i].ColumnName == "STRASSE1")
            //        {
            //            strasse = i;
            //            b_strasse = true;
            //        }
            //        if (dbf_tabelle.Columns[i].ColumnName == "ORT")
            //        {
            //            ort = i;
            //            b_ort = true;
            //        }
            //        if (dbf_tabelle.Columns[i].ColumnName == "PLZ")
            //        {
            //            b_plz = true;
            //            plz = i;
            //        }
            //    }
            //    for (int i = 0; i < dbf_tabelle.Columns.Count; i++)
            //    {

            //        if (dbf_tabelle.Columns[i].ColumnName == "LIEGENNR")
            //        {
            //            for (int j = 0; j < dbf_tabelle.Rows.Count; j++)
            //            {
            //                try
            //                {

            //                    string liegenschafts_nr = dbf_tabelle.Rows[j][i].ToString();
            //                    if (b_strasse)
            //                        strasse_str = dbf_tabelle.Rows[j][strasse].ToString();
            //                    if (b_ort)
            //                        ort_str = dbf_tabelle.Rows[j][ort].ToString();
            //                    if (b_plz)
            //                        plz_str = dbf_tabelle.Rows[j][plz].ToString();

            //                    string insert = "insert into liegenschaften (liegenschafts_nr, strasse, ort, plz) values ('" + liegenschafts_nr + "', '" + strasse_str + "', '" + ort_str + "', '" + plz_str + "')";
            //                    PgSqlCommand cmd_insert = new PgSqlCommand(insert, Verbindung);
            //                    cmd_insert.ExecuteNonQuery();
            //                }
            //                catch (Exception)
            //                {
            //                    string liegenschafts_nr = dbf_tabelle.Rows[j][i].ToString();
            //                    string insert = "insert into liegenschaften (liegenschafts_nr) values ('" + liegenschafts_nr + "')";
            //                    PgSqlCommand cmd_insert = new PgSqlCommand(insert, Verbindung);
            //                    cmd_insert.ExecuteNonQuery();
            //                }

            //            }
            //        }
            //    }


            //    akt_liegenschaften();
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Es konnten keine Liegenschaften überführt werden!");
            //}
            #endregion
            #region csv to dt
            //    folderBrowserDialog1.ShowDialog();
            //    try
            //    {
            //        string str = folderBrowserDialog1.SelectedPath + @"\AUSWERTUNG_OBJEKTE.csv";
            //        StreamReader str_rea = new StreamReader(str, Encoding.Default);
            //        string[] content = str_rea.ReadToEnd().Split(new string[] { Environment.NewLine }, System.StringSplitOptions.None);
            //        str_rea.Close();
            //        int counter = 1;
            //        while (counter < content.Length - 1)
            //        {
            //            string[] zeile = content[counter].Split(new Char[] { ';' });
            //            zeile = ersetzen(zeile);
            //            string lieg_nr = zeile[0];
            //            string strasse = zeile[5];
            //            int plz = int.Parse(zeile[3]);
            //            string ort = zeile[4];
            //            try
            //            {
            //                string insert = "insert into liegenschaften (liegenschafts_nr, strasse, ort, plz) values ('" + lieg_nr + "', '" + strasse + "', '" + ort + "','" + plz + "')";
            //                PgSqlCommand insert_cmd = new PgSqlCommand(insert, Verbindung);
            //                insert_cmd.ExecuteNonQuery();

            //            }
            //            catch (Exception)
            //            {
            //                MessageBox.Show("Fehler");
            //            }
            //            counter++;
            //            System.IO.File.Delete(folderBrowserDialog1.SelectedPath + @"\str.csv");
            //        }
            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show("Es konnte keine Liegenschaft übernommen werden!");
            //    }
            //    akt_liegenschaften();

            //}


            //private void button2_Click(object sender, EventArgs e)
            //{
            //    int dok_id = -1;
            //    try
            //    {
            //        dok_id = int.Parse(dataGridView1.CurrentRow.Cells["Position"].Value.ToString());
            //    }
            //    catch (Exception)
            //    {
            //    }
            //    if (dok_id != -1)
            //    {
            //        folderBrowserDialog1.ShowDialog();
            //        string ausgabe_pfad = folderBrowserDialog1.SelectedPath.ToString() + @"\" + dataGridView1.CurrentRow.Cells["name"].Value.ToString() + "." + dataGridView1.CurrentRow.Cells["format"].Value.ToString();
            //        if (!System.IO.File.Exists(ausgabe_pfad))
            //        {
            //            try
            //            {
            //                string getData = "select string from dokumente where Position = " + dok_id + " ";
            //                PgSqlCommand cmd_getData = new PgSqlCommand(getData, Verbindung);
            //                PgSqlDataReader rdr = cmd_getData.ExecuteReader();
            //                while (rdr.Read())
            //                {
            //                    byte[] data = Convert.FromBase64String(rdr[0].ToString());
            //                    FileStream neu = new FileStream(ausgabe_pfad, FileMode.Create);
            //                    neu.Write(data, 0, data.Length);
            //                    neu.Close();
            //                }

            //                rdr.Close();
            //            }
            //            catch (Exception)
            //            {

            //                MessageBox.Show("Die Datei konnte in dem gewünschten Verzeichnis nicht gespeichert werden!");
            //            }
            //        }
            //        else
            //            MessageBox.Show("Die Datei ist in dem Verzeichnis bereits vorhanden!");
            //    }

            //    else
            //        MessageBox.Show("Es ist kein Dokument ausgewählt!"); 
            #endregion
            liegenschaften_ueberfuehren();
        }

        private void pfadeÄndernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pfade_ändern pf = new Pfade_ändern(this);
            pf.ShowDialog();
        }

        private void tabellenErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Verbindung.ConnectionString = "user id = postgres;password = " + pw + ";host = " + host + ";port = " + port + ";database = postgres;pooling = true;min pool size = 0;max pool size = 100;connection lifetime = 0;";
                Verbindung.Open();
                string neue_tabelle = "CREATE TABLE liegenschaften (liegenschafts_nr text primary key, strasse text, plz int, ort text)";
                PgSqlCommand cmd_erzeuge = new PgSqlCommand(neue_tabelle, Verbindung);
                cmd_erzeuge.ExecuteNonQuery();
                string dokumente = "CREATE TABLE dokumente (position serial primary key, name text, string text, format text, datum date, bemerkung text, liegenschafts_nr text, jahr int, dok_typ text)";
                PgSqlCommand cmd_erzeuge2 = new PgSqlCommand(dokumente, Verbindung);
                cmd_erzeuge2.ExecuteNonQuery();
                Verbindung.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Tabellen sind schon vorhanden!");
            }
        }

        public string[] ersetzen(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = s[i].Replace("ß", "s%");
                s[i] = s[i].Replace("Ö", "O%");
                s[i] = s[i].Replace("ö", "o%");
                s[i] = s[i].Replace("Ä", "A%");
                s[i] = s[i].Replace("ä", "a%");
                s[i] = s[i].Replace("Ü", "U%");
                s[i] = s[i].Replace("ü", "u%");
            }
            return s;

        }

        private void liegenschaften_ueberfuehren()
        {
            string str = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dokument_Verwaltung\AUSWERTUNG_OBJEKTE.csv";
            if (File.Exists(str))
            {

                try
                {
                    StreamReader str_rea = new StreamReader(str, Encoding.Default);
                    string[] content = str_rea.ReadToEnd().Split(new string[] { Environment.NewLine }, System.StringSplitOptions.None);
                    str_rea.Close();
                    int counter = 1;
                    string[] zeile;
                    string lieg_nr = "0000000000";
                    string strasse = "";
                    string ort = "";
                    int plz = 0;
                    while (counter < content.Length - 1)
                    {
                        try
                        {
                            zeile = content[counter].Split(new Char[] { ';' });
                            zeile = ersetzen(zeile);
                            lieg_nr = zeile[0];
                            strasse = zeile[5];
                            plz = int.Parse(zeile[3]);
                            ort = zeile[4];
                        }
                        catch (Exception)
                        {
                        }
                        try
                        {
                            string insert = "insert into liegenschaften (liegenschafts_nr, strasse, ort, plz) values ('" + lieg_nr + "', '" + strasse + "', '" + ort + "','" + plz + "')";
                            PgSqlCommand insert_cmd = new PgSqlCommand(insert, Verbindung);
                            insert_cmd.ExecuteNonQuery();

                        }
                        catch (Exception)
                        {
                        }
                        counter++;
                        System.IO.File.Delete(str);
                    }
                }
                catch(Exception)
                {
                }

                akt_liegenschaften();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = dataGridView1.CurrentRow.Cells["format"].Value.ToString() + "|*." + dataGridView1.CurrentRow.Cells["format"].Value.ToString();
            saveFileDialog1.ShowDialog();
            try
            {

                string name = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                string format = dataGridView1.CurrentRow.Cells["format"].Value.ToString();
                int dok_id = int.Parse(dataGridView1.CurrentRow.Cells["Position"].Value.ToString());
                string pfad_voll = saveFileDialog1.FileName;
                dok.Clear();
                if (!System.IO.File.Exists(pfad_voll))
                {
                    string getData = "select string from dokumente where Position = " + dok_id + " ";
                    PgSqlCommand cmd_getData = new PgSqlCommand(getData, Verbindung);
                    PgSqlDataReader rdr = cmd_getData.ExecuteReader();
                    while (rdr.Read())
                    {
                        byte[] data = Convert.FromBase64String(rdr[0].ToString());
                        FileStream neu = new FileStream(pfad_voll, FileMode.Create);
                        neu.Write(data, 0, data.Length);
                        neu.Close();
                    }

                    rdr.Close();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Fehler!");
            }
            dokument_auswahl();
        }

        private void einmaligEinlesenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] a = System.IO.Directory.GetFiles(timer_pfad);
                int i = 0;
                try
                {
                    for (i = 0; i < a.Length; i++)
                    {
                        string pfad = a[i];
                        FileInfo fi = new FileInfo(pfad);
                        FileStream fs = fi.OpenRead();
                        byte[] buffer = new Byte[fi.Length];
                        fs.Read(buffer, 0, buffer.Length);
                        fs.Close();
                        string content = Convert.ToBase64String(buffer);
                        string[] datei = pfad.Split(new Char[] { '_' });
                        string format = datei[datei.Length - 1].Substring(datei[datei.Length - 1].Length - 3, 3);
                        string name = datei[datei.Length - 1].Substring(0, datei[datei.Length - 1].Length - 4);
                        string liegenschaftNr = datei[datei.Length - 7].Substring(datei[datei.Length - 7].Length - 10, 10);
                        //string datum_str = datei[datei.Length - 3];
                        string day = datei[datei.Length - 6];
                        string month = datei[datei.Length - 5];
                        string year = datei[datei.Length - 4];
                        string datum_str = month + "/" + day + "/" + year;
                        string jahr = datei[datei.Length - 3];
                        string typ_abk = datei[datei.Length - 2];
                        typ_abk = typ_abk.ToLower();
                        string typ = "";
                        //MessageBox.Show(liegenschaftNr + "  " + datum_str);
                        switch (typ_abk)
                        {
                            case "abr":
                                typ = "Abrechnungen";
                                break;
                            case "abl":
                                typ = "Ablesungsbelege";
                                break;
                            case "kol":
                                typ = "Kostenbelege";
                                break;
                            case "sch":
                                typ = "Schriftverkehr";
                                break;
                            case "son":
                                typ = "Sonstiges";
                                break;
                            case "leg":
                                typ = "Legionellen";
                                break;
                            case "ren":
                                typ = "Rechnungen";
                                break;
                            case "ver":
                                typ = "Verträge";
                                break;
                            case "ter":
                                typ = "Termine";
                                break;
                            case "kbl":
                                typ = "Kundenbelege";
                                break;
                            case "ted":
                                typ = "Technische Dokumente";
                                break;
                            case "eaw":
                                typ = "Energieausweise";
                                break;
                            default:
                                typ = "Keine Angaben";
                                break;

                        }
                        string insert = "insert into Dokumente (name, string, format, Liegenschafts_nr, dok_typ, jahr, datum) values ('" + name + "', '" + content + "', '" + format + "', '" + liegenschaftNr + "', '" + typ + "', '" + int.Parse(jahr) + "', '"+ datum_str +"')";
                        PgSqlCommand cmd = new PgSqlCommand(insert, Verbindung);
                        cmd.ExecuteNonQuery();
                        System.IO.File.Delete(a[i]);
                        dokument_auswahl();
                    }

                }

                catch (Exception exc)
                {
                    try
                    {
                        System.IO.File.Delete(a[i]);
                        MessageBox.Show(exc.ToString());
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString() + "\n" + exc.ToString());
                    }

                }
            }
            catch (Exception)
            {
            }
        }

        private void btn_change_lg_Click(object sender, EventArgs e)
        {
            try
            {
                //string select = "select position, name, format, datum, bemerkung, liegenschafts_nr, jahr, dok_typ from dokumente where liegenschafts_nr = '" + liegenschafts_nr + "'";
                string update = "UPDATE dokumente SET liegenschafts_nr='" + tbx_neu_lg.Text + "' WHERE liegenschafts_nr='" + tbx_alt_lg.Text + "'";
                PgSqlCommand cmd_update = new PgSqlCommand(update, Verbindung);
                cmd_update.ExecuteNonQuery();
                da_dok.Fill(dok);
                zeichen_ersetzen();
                dokument_auswahl();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Datenbankfehler oder ungültige Liegenschafts-Nummer!");
            }
        }




    }
}
