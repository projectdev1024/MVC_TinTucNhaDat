using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteMVC.Areas.AdminCP.Controllers
{
    public class ThongKeController : AdminController
    {
        public ActionResult Index(string sfromDate, string stoDate)
        {
            var fromDate = sfromDate.ToDate();
            var toDate = stoDate.ToDate();
            if (sfromDate == null)
            {
                fromDate = toDate.AddMonths(-1);
            }
            ViewBag.fromDate = fromDate.ToString("yyyy-MM-dd");
            ViewBag.toDate = toDate.ToString("yyyy-MM-dd");

            var query = db.Houses.Where(q => q.CreateTime >= fromDate && q.CreateTime <= toDate);

            return View(query.ToList());
        }
    }
}