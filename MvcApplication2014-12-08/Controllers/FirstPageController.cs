using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2014_12_08.Models;
using ToolFunction;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Data.Objects;
using System.Collections;

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
            var db = new STUDYEntities3();
            IEnumerable<PAT_VISIT> pats = from p in db.PAT_VISIT
                                         select p;
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (PAT_VISIT dr in pats)
            {
                SelectListItem si = new SelectListItem();
                si.Text = dr.ID.ToString();
                si.Value = dr.myID.ToString();
                items.Add(si);
            }
            ViewBag.fkfs = items;
            //DataTable DT = CommonFunction.ExecuteBySQL("select * from pat_visit",null,"pat_visit");
            //List<SelectListItem> items = new List<SelectListItem>();
            //foreach (DataRow dr in DT.Rows)
            //{
            //    SelectListItem si = new SelectListItem();
            //    si.Text = dr["id"].ToString();
            //    si.Value = dr["myid"].ToString();
            //    items.Add(si);
            //}
            //ViewBag.fkfs = items;
            return View("FirstPage");
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

        //[HttpPost]
        //public ActionResult SaveFirstPage(PAT_VISIT p)
        //{
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
            //var pp = new PAT_VISIT
            //{
            //    ID = p.ID,
            //    myID = p.myID,
            //    PATIENT_ID = p.PATIENT_ID,
            //    INP_NO = p.INP_NO
            //};
            //var db = new STUDYEntities2();
            //db.PAT_VISIT.Attach(pp);
            //db.ObjectStateManager.ChangeObjectState(pp, EntityState.Modified);
            //try
            //{
            //    db.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

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
           
        //    return View("FirstPage",p);
        //}
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
