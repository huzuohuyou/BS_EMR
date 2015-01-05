using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2014_12_08.Models;
using ToolFunction;
using System.Data;
using System.Data.Entity.Infrastructure;

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
            var pat_visit = new Pat_VisitModels
            {
                ID = "8e27f912-a6bd-4e3a-8e8b-bff38dd0e621",
                myID = "1",
                PATIENT_ID = "998",
                INP_NO = "hao123"
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
            //数据库插入
            //var pp = new PAT_VISIT{
            //    ID=Guid.NewGuid().ToString(),
            //    myID = p.myID,
            //    PATIENT_ID =p.PATIENT_ID,
            //    INP_NO = p.INP_NO
            //};
            //var db = new STUDYEntities1();
            //db.AddObject("PAT_VISIT", pp);
            //try
            //{
            //    db.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            //数据修改
            var pp = new PAT_VISIT
            {
                ID = p.ID,
                myID = p.myID,
                PATIENT_ID = p.PATIENT_ID,
                INP_NO = p.INP_NO
            };
            var db = new STUDYEntities1();
            db.PAT_VISIT.Attach(pp);
            db.ObjectStateManager.ChangeObjectState(pp, EntityState.Modified);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //数据删除
            //var pp = new PAT_VISIT
            //{
            //    ID = p.ID,
               
            //};
            //var db = new STUDYEntities1();
            //db.PAT_VISIT.Attach(pp);
            //db.ObjectStateManager.ChangeObjectState(pp, EntityState.Deleted);
            //try
            //{
            //    db.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
           
            return View("FirstPage",p);
        }
        /// <summary>
        /// 测试
        /// </summary>
        public void GetPat_Visit()
        {
            //EF_EMREntities ef_emr = new EF_EMREntities();
            //var pat_visit = new PAT_VISIT
            //{
            //    myID = "1",
            //    PATIENT_ID = "998"
            //};
            //ef_emr.PAT_VISIT.AddObject(pat_visit);
            //try
            //{
            //    ef_emr.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    CommonFunction.WriteErrorLog(ex.ToString());
            //}
        }
    }
}
