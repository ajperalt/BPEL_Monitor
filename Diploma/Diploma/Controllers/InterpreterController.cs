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
        private List<Process> _processList;
        private List<Instance> _instanceList;
        //
        // GET: /Interpreter/

        public ActionResult Index()
        {
            _processList = new List<Process>();

            InstanceManagement.InstanceManagement iManager = new InstanceManagement.InstanceManagement();
            var instances = iManager.listAllInstances().ToList();

            ProcessManagement.ProcessManagement pManager = new ProcessManagement.ProcessManagement();
            var processes = pManager.listAllProcesses();
            for (int i = 0; i < processes.Count(); i++)
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
        }


        public ActionResult Instances(string process = "TypicalMedicalProcess")
        {
            InstanceManagement.InstanceManagement iManager = new InstanceManagement.InstanceManagement();
            var instances = iManager.listAllInstances().ToList().Where(ins => ins.processname.Name == process);

            _instanceList = new List<Instance>();

            var generalInstCount = iManager.listAllInstances().ToList().Count;

            List<string> doctors = new List<string>();
            doctors.Add("Иванова О.С. (терапевт)");
            doctors.Add("Ефимова А.А (отоларинголог)");
            doctors.Add("Потемкина А.В (окулист)");
            doctors.Add("Стержнев Е.Б (хирург)");
            doctors.Add("Стеблев А.М. (ревматолог)");

            List<string> patients = new List<string>();
            patients.Add("Александров В.А");
            patients.Add("Иванов И.И.");
            patients.Add("Лебедев О.М");
            patients.Add("Любимов Г.М");
            patients.Add("Веригин М.В.");

            Random rand = new Random();
            int count = 0;
            using (InstanceDBContext context = new InstanceDBContext())
            {
                for (int i = 0; i < instances.Count(); i++)
                {

                    Instance curInst = new Instance();
                    curInst.DoctorName = doctors.ElementAt(rand.Next(0, doctors.Count));
                    curInst.PatientName = patients.ElementAt(rand.Next(0, patients.Count));
                    curInst.Id = i + 1;
                    curInst.percentOfComplite = rand.Next(0, 10) * 10;
                    _instanceList.Add(curInst);

                    context.Instances.Add(curInst);
                    context.SaveChanges();
                }
                count = context.Instances.Count();
            }
            return View(_instanceList);
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
