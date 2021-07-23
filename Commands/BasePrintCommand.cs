using TEI.Epos.Utilities.Interfaces;
using static TEI.Epos.Utilities.Printers.BasePrinter;

namespace TEI.Epos.Utilities.Commands
{
    public abstract partial class BasePrintCommand : IPrintCommand
    {
        public virtual void Print(string data) 
        {
            
        }
        public void Print(IFluentPrintDocumentBuilder document)
        {
            throw new System.NotImplementedException();
        }

        public void Print(IFluentPrintDocumentBuilder document, ShowPrintData showPrintData)
        {
            throw new System.NotImplementedException();
        }

        public void SetConfig(IPrinterConfig config)
        {

        }

    }
}
