using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Diploma.Models
{
    public class Instance
    {
        public int Id { get; set; }
        public string DoctorName { get; set; }

        public string PatientName { get; set; }

        public int percentOfComplite { get; set; }

    }

    public class InstanceDBContext : DbContext
    {
        public DbSet<Instance> Instances { get; set; }
    }
}