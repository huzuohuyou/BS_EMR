using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2014_12_08.Models;
using ToolFunction;

namespace MvcApplication2014_12_08.Controllers
{
    public class FirstPageController : Controller
    {
        //
        // GET: /FirstPage/

        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 填充首页信息
        /// </summary>
        public ActionResult FirstPage()
        {
            ViewData.Add("visit_id", 1);
            var pat_visit = new pat_visit {
            myID="1",
            PATIENT_ID="998",
            INP_NO="hao123"
            };
            return View("FirstPage",pat_visit);
        }

        public void GetPat_Visit()
        {
            EF_EMREntities ef_emr = new EF_EMREntities();
            var pat_visit = new PAT_VISIT
            {
                myID = "1",
                PATIENT_ID = "998"
            };
            ef_emr.PAT_VISIT.AddObject(pat_visit);
            try
            {
                ef_emr.SaveChanges();
            }
            catch (Exception ex)
            {
                CommonFunction.WriteErrorLog(ex.ToString());
            }
        }
    }
}
