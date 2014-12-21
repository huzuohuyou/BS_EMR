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
            //pat_visit p =
           
            return View();
        }
        /// <summary>
        /// 填充首页信息
        /// </summary>
        public ActionResult FirstPage()
        {
            ViewData.Add("visit_id", "zhuyuancishu");
            var pat_visit = new Pat_VisitModels {
            myID="1",
            PATIENT_ID="998",
            INP_NO="hao123"
            };
            return View("FirstPage",pat_visit);
        }
        ///// <summary>
        ///// 首页保存方法，测试从view获取信息
        ///// </summary>
        //public void SaveFirstPage(pat_visit p)
        //{

        ////p.
        //}
        //[HttpGet]
        //public ActionResult SaveFirstPage()
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult SaveFirstPage(Pat_VisitModels p)
        {

            string a = p.myID;
            string b = p.INP_NO;
            return View("FirstPage");
        }
        /// <summary>
        /// 测试
        /// </summary>
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
