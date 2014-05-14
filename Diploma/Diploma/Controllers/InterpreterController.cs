using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diploma.InstanceManagement;
using Diploma.ProcessManagement;
using Diploma.SoapInvokerV2;
using Diploma.Models;

namespace Diploma.Controllers
{
    public class InterpreterController : Controller
    {
        private ProcessDBContext _context = new ProcessDBContext();
        private List<Process> _processList = new List<Process>();
        //
        // GET: /Interpreter/

        public ActionResult Index()
        {
            //InvokeServices();

            InstanceManagement.InstanceManagement iManager = new InstanceManagement.InstanceManagement();
            var instances = iManager.listAllInstances().ToList();

            ProcessManagement.ProcessManagement pManager = new ProcessManagement.ProcessManagement();
            var processes = pManager.listAllProcesses();
            for(int i = 0; i < processes.Count(); i ++)
            {
                var process = new Process();
                process.Id = i + 1;
                process.Name = processes[i].definitioninfo.processname.Name;
                process.InstanceCount = instances.Where(inst => inst.processname == processes[i].definitioninfo.processname).Count();
                _processList.Add(process);

                //_context.Processes.Add(process);
                //_context.SaveChanges();
            }


            return View(_processList);
            //return "на страничке интерпретатора";
        }

        private static void InvokeServices()
        {
            SoapInvokerV2.Caller client = new Caller();
            CallerRequest req = new CallerRequest();
            req.input = "my input";
            CallerResponse resp = client.process(req);
            string message = resp.result;

            LengthyProcess.LengthyProcessService client2 = new LengthyProcess.LengthyProcessService();
            LengthyProcess.LengthyProcessRequest req2 = new LengthyProcess.LengthyProcessRequest();
            req2.input = "wait me";
            LengthyProcess.LengthyProcessResponse resp2 = client2.process(req2);
            string message2 = resp2.result;
        }

    }
}
