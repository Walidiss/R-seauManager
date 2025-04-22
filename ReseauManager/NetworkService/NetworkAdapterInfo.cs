using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkService
{
    public class NetworkAdapterInfo
    {
        public string Name { get; set; }
        public string Type { get; set; } // LAN / WiFi
        public string IPAddress { get; set; }
        public string Status { get; set; } // Enabled / Disabled
    }
}
