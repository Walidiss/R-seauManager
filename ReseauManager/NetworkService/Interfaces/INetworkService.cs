using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NetworkService.Interfaces
{
    [ServiceContract]
    public interface INetworkService
    {
        [OperationContract]
        List<NetworkAdapterInfo> GetNetworkAdapters();
    }
}
