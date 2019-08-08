using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace DokumentVerwaltung
{
    public class WiaImageEventArgs : EventArgs
    {

        public WiaImageEventArgs(Image img)
        {
            ScannedImage = img;
        }
        public Image ScannedImage { get; private set; }
    }
}
