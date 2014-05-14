using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleRestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISoapService" in both code and config file together.
    [ServiceContract]
    public interface ISoapService
    {
        [OperationContract]
        string GetData(string input);

        [OperationContract]
        string CreateNewAmbulatoryPatientTicket(string input);

        [OperationContract]
        string PassMedicalExamination(string input);
    }
}
