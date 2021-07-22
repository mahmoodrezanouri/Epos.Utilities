using System;

namespace Tei.Epos.Utilities.Printers
{
    public class PrinterStatusEventArgs : EventArgs
    {
        public bool IsPrinterOnline { get; set; }
    }
}