using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Diploma.Models
{
    public class Process
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InstanceCount { get; set; }
    }

    public class ProcessDBContext : DbContext
    {
        public DbSet<Process> Processes { get; set; }
    }
}