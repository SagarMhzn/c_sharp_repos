using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc2.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult displayDetail()
        {
            return View();
        }

        // creating own action method

        //public string displayDetail(string mark,string div)
        //{
        //    return "you got "+mark+" marks"+" and "+div+" division";
        //}


    }
}