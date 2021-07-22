using Tei.Epos.Utilities.Infrastructure.Helper;
using Tei.Epos.Utilities.Interfaces;
using System;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace Tei.Epos.Utilities.Command
{
    public partial class XmlPrintCommands : IPrintCommand
    {
        private string address = string.Empty;
        private INetworkConfig _networkConfig;

        public void Print(string data)
        {
        }

        public void Print(IFluentPrint document)
        {
           var request = document.ToXmlRequest();
            SendRequestToPrinter(request);
        }

        public void SetConfig(IConfig config)
        {
            _networkConfig = config as INetworkConfig;
            address = $"http://{_networkConfig.IpAddress}/cgi-bin/epos/service.cgi?devid={_networkConfig.PrinterName}&timeout={_networkConfig.TimeOut}";
        }

        private void SendRequestToPrinter(XElement req)
        {
            WebClient client = new WebClient();
            client.Headers["Content-Type"] = "text/xml; charset=utf-8";
            var result = client.UploadString(new Uri(address, UriKind.Absolute), req.ToString());
        }

    }
}
