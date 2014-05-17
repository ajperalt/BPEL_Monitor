using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleRestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceTools" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceTools.svc or ServiceTools.svc.cs at the Solution Explorer and start debugging.
    public class ServiceTools : IServiceTools
    {
        public string GenerateServiceGuid(string servName)
        {
            return Guid.NewGuid().ToString();
        }


        public bool SaveStatus(string serviceGuid)
        {
            
            return true;
        }
    }
}
