using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BKMvcApplication.Models;
using BKMvcApplication.DTO.Problems;
using System.Web.Script.Serialization;


namespace BKMvcApplication.Controllers
{
    public class ProblemsController : Controller
    {
        //
        // GET: /Problems/
        BKEntities bk = new BKEntities();
        public ActionResult Allquestions()
        {
            return View();
        }
        public ActionResult Stayback()
        {
            return View();
        }
        public ActionResult Resolved()
        {
            return View();
        }
        public ActionResult Classification()
        {
            List<Problems_Type> list = bk.Problems_Type.ToList();
            ViewBag.list = list;
            return View();
        }
        public ActionResult Index4()
        {
            return View();
        }
        public JsonResult king()
        {
            int Page=Convert.ToInt32(Request["Page"]);
            int Rows=Convert.ToInt32(Request["Rows"]);
            if (Session["bklist"] == null)
            {
                SQL_sjk();
            }
            List<DTO_Problems> List = Session["bklist"] as List<DTO_Problems>;
            List<DTO_Problems> bklists = List.OrderBy(a => a.Problems_Name).Skip((Page - 1) * Rows + 1).Take(Rows).ToList();

            DTO_Num Dm = new DTO_Num();
            Dm.Num = Convert.ToInt32(Session["Num"]);
            Dm.DTO_Problems =bklists;
            return Json(Dm, JsonRequestBehavior.AllowGet);
        }
        public void SQL_sjk()
        {

            var bklist = from p in bk.Problems
                         join u in bk.UserInfo on p.Problems_UserId equals u.UserId
                         join pt in bk.Problems_Type on p.Problems_Type_Id equals pt.Problems_Type_Id
                         select new DTO_Problems
                         {
                             Problems_Name = u.UserName,
                             Problems_Type_Problem = pt.Problems_Type_Name,
                             Problems_CollectCount = p.Problems_CollectCount,
                             Problems_Id = p.Problems_Id,
                             Problems_Content = p.Problems_Content,
                             Problems_IsSolve = p.Problems_IsSolve,
                             Problems_Money = p.Problems_Money,
                             Problems_SeeCount = p.Problems_SeeCount,
                             Problems_Time = p.Problems_Time,
                             Problems_Title = p.Problems_Title,

                         };
            //
            List<DTO_Problems> Bklist = bklist.ToList();
            int Num = 0;
            if (Bklist.Count % 10 == 0)
            {
                Num = Bklist.Count / 10;
            }
            else
            {
                Num = Bklist.Count / 10;
                Num = Num + 1;
            }
            Session["Num"] = Num;
            Session["bklist"] = bklist.ToList();
        }
    }
}
