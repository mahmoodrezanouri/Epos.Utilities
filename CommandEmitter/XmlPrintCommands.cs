using Epos.Utilities.Infrastructure.Helper;
using Epos.Utilities.Interfaces;
using System;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace Epos.Utilities.Command
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

        // Send print document
        private void SendRequestToPrinter(XElement req)
        {
            WebClient client = new WebClient();
            client.Headers["Content-Type"] = "text/xml; charset=utf-8";
            // client.UploadStringCompleted += new UploadStringCompletedEventHandler(UploadStringCompleted);
            //client.UploadStringAsync(new Uri(address, UriKind.Absolute), req.ToString());
            var result = client.UploadString(new Uri(address, UriKind.Absolute), req.ToString());
        }

    }
}
