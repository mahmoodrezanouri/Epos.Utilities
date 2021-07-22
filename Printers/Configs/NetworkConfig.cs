using Tei.Epos.Utilities.Interfaces;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Tei.Epos.Utilities.Printers
{
    public class NetworkConfig : INetworkConfig
    {
        public string IpAddress { get; set; }
        public int Port { get; set; }
        public string PrinterName { get; set; }
        public int TimeOut { get; set; }
 
    }
}
