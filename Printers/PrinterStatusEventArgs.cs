using System;

namespace TEI.Epos.Utilities.Printers
{
    public class PrinterStatusEventArgs : EventArgs
    {
        public string PrintData { get; set; }
    }
}