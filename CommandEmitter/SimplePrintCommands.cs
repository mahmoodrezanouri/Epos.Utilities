using Tei.Epos.Utilities.Infrastructure.Helper;
using Tei.Epos.Utilities.Interfaces;
using System;
using System.Net;
using System.Text;
using System.Xml.Linq;
using static Tei.Epos.Utilities.Printers.NetworkPrinter;

namespace Tei.Epos.Utilities.Command
{
    public partial class SimplePrintCommands : IPrintCommand
    {
        private string address = string.Empty;
        private INetworkConfig _networkConfig;

        public void Print(string data)
        {
        }


        public void Print(IFluentPrint document)
        {
           //var request = document.ToXmlRequest();
        }

        public void Print(IFluentPrint document, ShowPrintData showPrintData)
        {
            var printDoc = document.Build();

            var request = string.Empty;

            foreach (var doc in printDoc)
            {
                var textLineDocumentElement = (BaseTextLineDocumentElement)doc;
                request += textLineDocumentElement.Value;
            }

            showPrintData($"Printer : {_networkConfig.PrinterName}{Environment.NewLine}IP : {_networkConfig.IpAddress }{Environment.NewLine}Print Data : {request}");
        }

        public void SetConfig(IConfig config)
        {
            _networkConfig = config as INetworkConfig;
        }

    }
}
