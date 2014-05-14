using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.SoapInvokerV2;
using ConsoleClient.ProcessManagement;
using ConsoleClient.LengthyProcess;
using ConsoleClient.SoapService;
using ConsoleClient.TypicalMedicalProcess;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SoapInvokerV2.CallerBinding bind = new CallerBinding();
            CallerRequest req = new CallerRequest();
            req.input = "my input";
            CallerResponse resp = bind.process(req);
            Console.WriteLine(resp.result);

            LengthyProcess.LengthyProcess client = new LengthyProcess.LengthyProcess();
            LengthyProcessRequest request = new LengthyProcessRequest();
            request.input = "test message";
            LengthyProcessResponse response = client.process(request);
            Console.WriteLine(response.result);

            ProcessManagement.ProcessManagement pmanager = new ProcessManagement.ProcessManagement();
            var processes = pmanager.listAllProcesses();

            TypicalMedicalProcess.TypicalMedicalProcessBinding tmpBinding = new TypicalMedicalProcessBinding();
            TypicalMedicalProcessRequest request3 = new TypicalMedicalProcessRequest();
            request3.input = "oms";
            TypicalMedicalProcessResponse response3 = tmpBinding.process(request3);
            string respMessage3 = response3.result;

            Console.ReadKey();
        }
    }
}