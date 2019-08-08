using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using System.IO;
using WIA;
using iTextSharp.text;
using iTextSharp.text.pdf;
//using PdfSharp;
//using PdfSharp.Pdf;
//using PdfSharp.Drawing;

namespace DokumentVerwaltung
{
    public partial class Neues_Dokument_scannen : Form
    {
        Form1 Hauptfenster;
        int pdfdocs = 1;
        string liegenschafts_nr;
        string pfad;
        internal PgSqlConnection Verbindung = new PgSqlConnection();
        internal PgSqlDataAdapter da_dok = new PgSqlDataAdapter();
        internal DataTable dok = new DataTable();

        public Neues_Dokument_scannen(Form1 aufrufendes_fenster)
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
            liegenschafts_nr =  Hauptfenster.dataGridView2.CurrentRow.Cells["liegenschafts_nr"].Value.ToString();

        }

        private void btn_scannen_Click(object sender, EventArgs e)
        {
            if (rdb_spl.Checked)
            {
                btn_scannen.Enabled = false;
                tbx_name.Enabled = false;
                tbx_bemerkung.Enabled = false;
                dtp_datum.Enabled = false;
                lbx_dokument_typ.Enabled = false;
                string wiaFormatJPEG = "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}";
                WIA.CommonDialog cd = new WIA.CommonDialog();
                WIA.Device dev = null;
                dev = cd.ShowSelectDevice(WiaDeviceType.ScannerDeviceType, true, false);
                dev.Properties["Pages"].set_Value(1);
                //dev.Properties["3088"].set_Value(5);
                Item dt = dev.Items[1];
                dt.Properties["6147"].set_Value(300);
                dt.Properties["6148"].set_Value(300);
                try
                {
                    int counter = -1;
                    while (true)
                    {
                        counter++;
                        WIA.CommonDialog common = new WIA.CommonDialog();
                        ImageFile image = common.ShowTransfer(dev.Items[1], wiaFormatJPEG, true);
                        pfad = Hauptfenster.tempo_pfad + @"\" + tbx_name.Text + counter.ToString() + ".jpg";
                        Byte[] imageBytes = (byte[])image.FileData.get_BinaryData();
                        MemoryStream ms = new MemoryStream(imageBytes);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                        JpegBildKomprimieren(img, int.Parse(textBox1.Text), pfad);
                        //image.SaveFile(pfad);
                    }
                }
                catch (Exception)
                {
                }
                btn_erstellen.Enabled = true;
            }
            else if (rdb_dpl.Checked)
            {
                btn_scannen.Enabled = false;
                tbx_name.Enabled = false;
                tbx_bemerkung.Enabled = false;
                dtp_datum.Enabled = false;
                lbx_dokument_typ.Enabled = false;
                string wiaFormatJPEG = "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}";
                WIA.CommonDialog cd = new WIA.CommonDialog();
                WIA.Device dev = null;
                dev = cd.ShowSelectDevice(WiaDeviceType.ScannerDeviceType, true, false);
                dev.Properties["Pages"].set_Value(1);
                //dev.Properties["3088"].set_Value(5);
                Item dt = dev.Items[1];
                dt.Properties["6147"].set_Value(300);
                dt.Properties["6148"].set_Value(300);
                int counter = -1;
                try
                {
                    
                    while (true)
                    {
                        counter +=2;
                        WIA.CommonDialog common = new WIA.CommonDialog();
                        ImageFile image = common.ShowTransfer(dev.Items[1], wiaFormatJPEG, true);
                        if(counter < 10)
                            pfad = Hauptfenster.tempo_pfad + @"\0" + counter.ToString() + ".jpg";
                        else
                            pfad = Hauptfenster.tempo_pfad + @"\" + counter.ToString() + ".jpg";
                        Byte[] imageBytes = (byte[])image.FileData.get_BinaryData();
                        MemoryStream ms = new MemoryStream(imageBytes);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                        JpegBildKomprimieren(img, int.Parse(textBox1.Text), pfad);
                        //image.SaveFile(pfad); !
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Scannen abgeschlossen");
                }
                #region Alt_Dup
                if (MessageBox.Show("Rückseite eingelegt?", "Duplex", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dt.Properties["6147"].set_Value(300);
                    dt.Properties["6148"].set_Value(300);
                    try
                    {
                        int counter2 = counter + 1;
                        while (true)
                        {
                            counter2 -= 2;
                            WIA.CommonDialog common = new WIA.CommonDialog();
                            ImageFile image = common.ShowTransfer(dev.Items[1], wiaFormatJPEG, true);
                            if (counter2 < 10)
                                pfad = Hauptfenster.tempo_pfad + @"\0" + counter2.ToString() + ".jpg";
                            else
                                pfad = Hauptfenster.tempo_pfad + @"\" + counter2.ToString() + ".jpg";
                            Byte[] imageBytes = (byte[])image.FileData.get_BinaryData();
                            MemoryStream ms = new MemoryStream(imageBytes);
                            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                            JpegBildKomprimieren(img, int.Parse(textBox1.Text), pfad);
                            //image.SaveFile(pfad);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Scannen abgeschlossen");
                    }
                }
                else
                {
                    string[] a = System.IO.Directory.GetFiles(Hauptfenster.tempo_pfad);
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
                    this.Close();
                }
                
                #endregion
                btn_erstellen.Enabled = true;


            }
             #region lustiger toter Code
                //try
                //{
                //WIA.CommonDialog wcd = new WIA.CommonDialog();
                //Device d = wcd.ShowSelectDevice(WiaDeviceType.ScannerDeviceType, true, false);
                //int c = 0;
                //pfad = Hauptfenster.tempo_pfad + @"\" + tbx_name.Text + c.ToString() + ".jpg";
                //while (true)
                //{
                //    WIA.ImageFile img = new ImageFile();
                //    WIA.CommonDialog WiaCommonDialog = new WIA.CommonDialog();
                //    WIA.Item Item = d.Items[1] as WIA.Item;
                //    img = (ImageFile)WiaCommonDialog.ShowTransfer(Item, wiaFormatJPEG, false);
                //    c++;
                //    pfad = Hauptfenster.tempo_pfad + @"\" + tbx_name.Text + c.ToString() + ".jpg";
                //    MessageBox.Show(pfad);
                //    img.SaveFile(pfad);

                //}
                //btn_erstellen.Enabled = true;
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Es konnte keine Verbindung zum Scanner hergestellt werden!");
                //    btn_erstellen.Enabled = true;
                //}
                //try
                //{
                //    int c = 0;
                //    const string wiaFormatJPEG = "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}";
                //    WIA.CommonDialog wiaDiag = new WIA.CommonDialog();
                //    WIA.ImageFile wiaImage = null;
                //    while (true)
                //    {
                //        wiaImage = wiaDiag.ShowAcquireImage(
                //        WiaDeviceType.ScannerDeviceType,
                //        WiaImageIntent.GrayscaleIntent,
                //        WiaImageBias.MaximizeQuality,
                //        wiaFormatJPEG, true, true, false);

                //        WIA.Vector vector = wiaImage.FileData;
                //        Image i = Image.FromStream(new MemoryStream((byte[])vector.get_BinaryData()));
                //        c++;
                //        pfad = Hauptfenster.tempo_pfad + @"\" + tbx_name.Text + c.ToString() + ".jpg";
                //        i.Save(pfad);
                //    }
                //}
                //catch (Exception)
                //{

                //  btn_erstellen.Enabled = true;
                //} 
                #endregion
    
        }
               

        private void btn_erstellen_Click(object sender, EventArgs e)
        {
            bool scs = true;
            try
            {
                if (rdb_spl.Checked)
                {
                    #region JPG to PDF
                    //string[] source = System.IO.Directory.GetFiles(Hauptfenster.tempo_pfad);
                    //pfad = Hauptfenster.tempo_pfad + @"\" + tbx_name.Text + "0.pdf";
                    //PdfDocument doc = new PdfDocument();
                    //for (int i = 0; i < source.Length; i++)
                    //{
                    //    doc.Pages.Add(new PdfPage());
                    //    XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[i]);
                    //    XImage img = XImage.FromFile(source[i]);

                    //    xgr.DrawImage(img, 0, 0);
                    //}
                    //doc.Save(pfad);
                    //doc.Close();
                    #endregion
                    #region iPDF
                    string[] source = System.IO.Directory.GetFiles(Hauptfenster.tempo_pfad);
                    if (source.Length != 0)
                    {
                        pfad = Hauptfenster.tempo_pfad + @"\" + tbx_name.Text + ".pdf";
                        //float margin = Utilities.MillimetersToPoints(Convert.ToSingle(20));
                        Document doc = new Document(iTextSharp.text.PageSize.A4);

                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pfad, FileMode.Create));
                        writer.SetFullCompression();
                        writer.CloseStream = true;

                        doc.Open();
                        for (int i = 0; i < source.Length; i++)
                        {
                            doc.NewPage();
                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(source[i]);
                            img.ScaleToFit(1500, 900);
                            doc.Add(img);
                        }
                        doc.Close();
                    }
                    else
                    {
                        MessageBox.Show("Keine gescannten Dateien vorhanden.");
                        scs = false;
                    }
                    #endregion
                }
                else if(rdb_dpl.Checked)
                {
                   #region JPG to PDF
                    //string[] source = System.IO.Directory.GetFiles(Hauptfenster.tempo_pfad);
                    ////string[] source = new string[temp.Length];
                    ////for (int i = 1; i < temp.Length; i ++)
                    ////{
                    ////    foreach (string s in temp)
                    ////    {
                    ////        MessageBox.Show(s.Substring(Hauptfenster.tempo_pfad.Length - 1, 1) + "\n" + s);
                    ////        if (temp[i] == s.Substring(Hauptfenster.tempo_pfad.Length - 1, 1))
                    ////            source[i] = s;
                    ////    }
                    ////}
                    //int c = source.Length / 40 + 1;
                    //pdfdocs = c;
                    //for (int j = 0; j < c; j++)
                    //{
                    //    MessageBox.Show("Seite:" + (j + 1).ToString());
                    //    pfad = Hauptfenster.tempo_pfad + @"\" + tbx_name.Text + j.ToString() + ".pdf";
                    //    PdfDocument doc = new PdfDocument();
                    //    for (int i = j*40; i < (j*40)+40; i++)
                    //    {
                    //        if (i < source.Length)
                    //        {
                    //            if (textBox1.Text == "257")
                    //                MessageBox.Show(i + "\n" + source[i]);
                    //        //MessageBox.Show(i.ToString());
                    //        doc.Pages.Add(new PdfPage());
                    //        XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[i-(j*40)]);
                    //        XImage img = XImage.FromFile(source[i]);
                    //        xgr.DrawImage(img, 0, 0);
                    //        }

                    //    }
                    //    doc.Save(pfad);
                    //    doc.Close();
                    //}
                    #endregion
                    #region iPDF
                    string[] source = System.IO.Directory.GetFiles(Hauptfenster.tempo_pfad);
                    if (source.Length != 0)
                    {
                        pfad = Hauptfenster.tempo_pfad + @"\" + tbx_name.Text + ".pdf";
                        // margin = Utilities.MillimetersToPoints(Convert.ToSingle(20));
                        Document doc = new Document(iTextSharp.text.PageSize.A4);

                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pfad, FileMode.Create));
                        writer.SetFullCompression();
                        writer.CloseStream = true;

                        doc.Open();
                        for (int i = 0; i < source.Length; i++)
                        {
                            doc.NewPage();
                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(source[i]);
                            img.ScaleToFit(1500, 900);
                            doc.Add(img);
                        }
                        doc.Close();
                    }
                    else
                    {
                        MessageBox.Show("Keine gescannten Dateien vorhanden.");
                        scs = false;
                    }
                    #endregion

                }
          
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                scs = false;
            }
            System.Threading.Thread.Sleep(5000);
            if (scs)
            {
                try
                {
                            FileInfo fi = new FileInfo(pfad);
                            FileStream fs = fi.OpenRead();
                            byte[] buffer = new Byte[fi.Length];
                            fs.Read(buffer, 0, buffer.Length);
                            fs.Close();
                            string datei = Convert.ToBase64String(buffer);
                            int jahr = int.Parse(Hauptfenster.nud_jahr.Value.ToString());
                            string name = ersetzen(tbx_name.Text);
                            string bemerkung = ersetzen(tbx_bemerkung.Text);
                            string date = dtp_datum.Value.Month.ToString() + "/" + dtp_datum.Value.Day.ToString() + "/" + dtp_datum.Value.Year.ToString();
                            string insert = "insert into dokumente (name, string, format, datum, bemerkung, liegenschafts_nr, jahr, dok_typ) values ('" + name + "', '" + datei + "', '" + pfad.Substring(pfad.Length - 3, 3) + "', '" + date + "', '" + bemerkung + "', '" + liegenschafts_nr + "', '" + jahr + "', '" + lbx_dokument_typ.Text + "')";
                            PgSqlCommand cmd_insert = new PgSqlCommand(insert, Verbindung);
                            cmd_insert.ExecuteNonQuery();
                            this.Close();
 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    this.Close();
                } 
            }
            this.Close();
        }

        private void tbx_name_TextChanged(object sender, EventArgs e)
        {
            if (tbx_name.Text != "")
                btn_scannen.Enabled = true;
            else
                btn_scannen.Enabled = false;
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

        private void SetProperty(Property property, int value)
        {
            IProperty x = (IProperty)property;
            Object val = value;
            x.set_Value(ref val);
        }

        private void JpegBildKomprimieren(System.Drawing.Image quellBild, int qualitaet, string speicherPfad)
        {
            //http://code-bude.net/2011/06/03/bilder-mit-jpeg-beliebig-komprimieren-in-c/
            try
            {
                ImageCodecInfo jpegCodec = null;
                EncoderParameter qualitaetsParameter = new EncoderParameter(
                            System.Drawing.Imaging.Encoder.Quality, qualitaet);

                ImageCodecInfo[] alleCodecs = ImageCodecInfo.GetImageEncoders();

                EncoderParameters codecParameter = new EncoderParameters(1);
                codecParameter.Param[0] = qualitaetsParameter;
                for (int i = 0; i < alleCodecs.Length; i++)
                {
                    if (alleCodecs[i].MimeType == "image/jpeg")
                    {
                        jpegCodec = alleCodecs[i];
                        break;
                    }
                }

                quellBild.Save(speicherPfad, jpegCodec, codecParameter);
            }
            catch (Exception e)
            {
            }
        }

    }
}
