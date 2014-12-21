using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToolFunction;
using System.Data.Entity;

namespace MvcApplication2014_12_08.Models
{
    public class Pat_VisitContext : DbContext
    {
        public Pat_VisitContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Pat_VisitModels> Pat_VisitModels { get; set; }
    
    }
    public class Pat_VisitModels
    {
        public string myID { get; set; }
        public string INP_NO { get; set; }
        public string PATIENT_ID { get; set; }

       
    }
}