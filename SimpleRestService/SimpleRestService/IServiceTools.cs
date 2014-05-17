using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleRestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceTools" in both code and config file together.
    [ServiceContract]
    public interface IServiceTools
    {
        [OperationContract]
        string GenerateServiceGuid(string servName);

        [OperationContract]
        bool SaveStatus(string serviceGuid);
    }
}
