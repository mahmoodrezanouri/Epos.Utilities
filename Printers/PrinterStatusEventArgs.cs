using System;

namespace Tei.Epos.Utilities.Printers
{
    public class PrinterStatusEventArgs : EventArgs
    {
        public string PrintData { get; set; }
    }
}