using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleRestService
{
    public class SoapService : ISoapService
    {
        public static int counter = 0;
        public string GetData(string input)
        {
            return String.Format("Soap Input Message: {0}", input);
        }


        public string CreateNewAmbulatoryPatientTicket(string input)
        {
            DateTime start = DateTime.Now.AddDays(2);
            Random gen = new Random();

            int range = (start.AddDays(10.0) - start).Days;
            DateTime randDate = start.AddDays(gen.Next(range));
            string formattedDate = "" + randDate.Year + "-" + randDate.Month + "-" + randDate.Day + "T" + randDate.Hour + ":" + randDate.Minute;
            //return formattedDate;
            return "New ambulatory ticket was created";
        }


        public string PassMedicalExamination(string input)
        {
            DateTime start = DateTime.Now.AddDays(7);
            Random gen = new Random();

            int range = (start.AddDays(15.0) - start).Days;
            DateTime randDate = start.AddDays(gen.Next(range));
            string formattedDate = "" + randDate.Year + "-" + randDate.Month + "-" + randDate.Day + "T" + randDate.Hour + ":" + randDate.Minute;
            //string formattedDate = randDate.ToLongTimeString();
            //return formattedDate;
            
            counter += 1;
            return counter + ") MedicalExamination was passed";
        }
    }
}
