using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcApplication2014_12_08.Models
{
    public class PAT_VISIT : DbContext
    {
        public string ID { get; set; }
        public string myID { get; set; }
        public string INP_NO { get; set; }
        public string PATIENT_ID { get; set; }

    }
}