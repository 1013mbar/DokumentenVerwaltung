using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DokumentVerwaltung
{
    public partial class Pfade_ändern : Form
    {
        Form1 Hauptfenster;
        public Pfade_ändern(Form1 aufrufendes_Fenster)
        {
            Hauptfenster = aufrufendes_Fenster;
           InitializeComponent();
        }

        private void btn_aendern_Click(object sender, EventArgs e)
        {
            if (tbx_timer_pfad.Text == "" || tbx_tempo_pfad.Text == "")
            {
                MessageBox.Show("Es wurden keine Änderungen vorgenommen!");
                Close();
            }
            else
            {
                if (ordner_vorhanden(tbx_tempo_pfad.Text))
                {
                    Hauptfenster.WriteLine(Hauptfenster.txt_pfad, 2, tbx_tempo_pfad.Text);
                    Hauptfenster.tempo_pfad = tbx_tempo_pfad.Text;
                }
                else
                    MessageBox.Show("Keine gültiger Pfad für den Tempo-Ordner!");
                if (ordner_vorhanden(tbx_timer_pfad.Text))
                {
                    Hauptfenster.WriteLine(Hauptfenster.txt_pfad, 3, tbx_timer_pfad.Text);
                    Hauptfenster.timer_pfad = tbx_timer_pfad.Text;
                }
                else
                    MessageBox.Show("Keine gültiger Pfad für den Timer-Ordner!");
                Close();
            }

            
        }

        private void btn_exp_tempo_Click(object sender, EventArgs e)
        {
            fbd_tempo.ShowDialog();
            if (fbd_tempo.SelectedPath.ToString() != "")
                tbx_tempo_pfad.Text = fbd_tempo.SelectedPath.ToString();
            
        }

        private void btn_exp_timer_Click(object sender, EventArgs e)
        {
            fbd_timer.ShowDialog();
            if(fbd_timer.SelectedPath.ToString() != "")
                tbx_timer_pfad.Text = fbd_timer.SelectedPath.ToString();
        }

        private void Pfade_ändern_Load(object sender, EventArgs e)
        {
            tbx_tempo_pfad.Text = Hauptfenster.tempo_pfad;
            tbx_timer_pfad.Text = Hauptfenster.timer_pfad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hauptfenster.tempo_pfad = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dokument_Verwaltung\tempo";
            Hauptfenster.timer_pfad = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dokument_Verwaltung\timer";
            MessageBox.Show("Ordner für temporäre Daten: " + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dokument_Verwaltung\tempo" + "\n" + 
                            "Ordner zum einlesen von Daten: " + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dokument_Verwaltung\timer");
            Hauptfenster.WriteLine(Hauptfenster.txt_pfad, 2, Hauptfenster.tempo_pfad);
            Hauptfenster.WriteLine(Hauptfenster.txt_pfad, 3, Hauptfenster.timer_pfad);
            Close();
        }

        private bool ordner_vorhanden(string pfad)
        {
            if (System.IO.Directory.Exists(pfad))
                return true;
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
