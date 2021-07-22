using static Tei.Epos.Utilities.Printers.NetworkPrinter;

namespace Tei.Epos.Utilities.Interfaces
{
    public interface IPrintCommand
    {
        void Print(string data);

        void Print(IFluentPrint document);

        void SetConfig(IConfig config);

        void Print(IFluentPrint document, ShowPrintData showPrintData);
    }
}
