using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace NetworkHost
{
  

    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(NetworkService.Services.NetworkService)))
            {
                host.Open();
                Console.WriteLine("Service réseau lancé sur http://localhost:5000");
                Console.ReadLine();
            }
        }
    }
}
