using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc2.Models;


namespace mvc2.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult displayDetail()
        {
            var res = GetDetail();
            return View(res);
        }

        private subject GetDetail()
        {
            return new subject()
            {
                Id = 101,
                subjectName = "Ncc"

            };
        }

        // creating own action method

        //public string displayDetail(string mark,string div)
        //{
        //    return "you got "+mark+" marks"+" and "+div+" division";
        //}


    }
}