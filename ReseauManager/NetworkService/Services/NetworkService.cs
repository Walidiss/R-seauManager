using NetworkService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NetworkService.Services
{
    public class NetworkService : INetworkService
    {
        public List<NetworkAdapterInfo> GetNetworkAdapters()
        {
            var list = new List<NetworkAdapterInfo>();

            foreach (var nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Loopback)
                    continue;

                var ip = nic.GetIPProperties()
                            .UnicastAddresses
                            .FirstOrDefault(a => a.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);

                list.Add(new NetworkAdapterInfo
                {
                    Name = nic.Name,
                    Type = nic.NetworkInterfaceType.ToString(),
                    IPAddress = ip?.Address.ToString() ?? "N/A",
                    Status = nic.OperationalStatus.ToString()
                });
            }

            return list;
        }
    }
}
