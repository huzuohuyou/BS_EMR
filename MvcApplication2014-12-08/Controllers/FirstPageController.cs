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
            
            //使用SQO(标准查询运算符),查询
            //实际返回的是IQueryable 接口的之类对象
            //IQueryable<Models.Customer> query = db.Customers.Where(d => d.Address == "111");
            //这样转有可能报异常 EnumerableQuery<Models.Customer> query = (EnumerableQuery<Models.Customer>)db.Customers.Where(d => d.Address == "111");
            //DbQuery 支持延迟加载，就是只有使用到数据的时候，才去查询数据库
            
            //DbQuery<Models.Customer> query = db.Customers.Where(d => d.Address == "111") as DbQuery<Models.Customer>;
            //List<Models.Customer> list = query.ToList();
            //也可以这样
            // List<Models.Customer> list = db.Customers.Where(d => d.Address == "111").ToList();
            //用第二种方式:使用Linq语句,该语法只是给程序员用的,.net编译器会在编译程序集的时候把它转化为SQO
            //IQueryable<Models.Customer> query = from d in db.Customers where d.Address == "111" select d;
            //List<Models.Customer> list = (from d in db.Customers where d.Address == "111" select d).ToList();

           // List<Models.Customer> list = (from d in db.Customers select d).ToList();
           ////使用ViewData将数据传给View
           // ViewData["DataList"] = list;
           // return View();
            //ViewData.Add("visit_id", "zhuyuancishu");
            //var pat_visit = new Pat_VisitModels
            //{
            //    ID = "8e27f912-a6bd-4e3a-8e8b-bff38dd0e621",
            //    myID = "1",
            //    PATIENT_ID = "998",
            //    INP_NO = "hao123"
            //};
            //ViewBag.pi = patinfo;
            var db = new STUDYEntities1();
            //ObjectQuery<PAT_VISIT> pats1 = db.CreateQuery<PAT_VISIT>();
            IQueryable<PAT_VISIT> pats = from p in db.PAT_VISIT
                                        select p;
            List<PAT_VISIT> items = new List<PAT_VISIT>();
            foreach (var item in pats)
            {
                items.Add(item);
            }
            ViewBag.fkfs = items;
            return View("FirstPage",items);
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
        public ActionResult SaveFirstPage(PAT_VISITModels p)
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
