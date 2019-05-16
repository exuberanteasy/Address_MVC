using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DynamicDropdown.Models;

namespace DynamicDropdown.Controllers
{
    public class HomeController : Controller
    {
        CRContext crDBContext = new CRContext();



        public ActionResult Index()
        {
            IEnumerable<SelectListItem> CityList = crDBContext.Cities.Select(c => new SelectListItem
            {
                Value = c.CityId,
                Text = c.CityName
            });

            ViewBag.CityList = CityList;

            IEnumerable<SelectListItem> RegionList = crDBContext.Regions.Where(c => c.CityId == "1").Select(c => new SelectListItem
            {
                Value = c.RegionId,
                Text = c.RegionName
            });

            ViewBag.RegionList = RegionList;

            return View();
        }

        public JsonResult GetRegions(string CityId)
        {
            var RegionList = crDBContext.Regions.Where(c => c.CityId == CityId).Select(c => new
            {
                RegionId = c.RegionId,
                RegionName = c.RegionName,
            }).ToList();

            return Json(RegionList, JsonRequestBehavior.AllowGet);
        }


        public JsonResult Test()
        {
            IEnumerable<SelectListItem> CityList = crDBContext.Cities.Select(c => new SelectListItem
            {
                Value = c.CityId,
                Text = c.CityName
            });

            return Json(CityList, JsonRequestBehavior.AllowGet);

        }

        //public JsonResult TestRegion()
        //{
        //    IEnumerable<SelectListItem> RegionList = crDBContext.Regions.Select(c => new SelectListItem
        //    {
        //        Value = c.RegionId,
        //        Text = c.RegionName
        //    });

        //    return Json(RegionList, JsonRequestBehavior.AllowGet);

        //}

        public string TestRegion()
        {
            //AddressModel db = new AddressModel();

            CRContext db = new CRContext();

            var result = db.Regions;

            string show = "";

            foreach (var item in result)
            {
                show += item.RegionId;
                show += item.RegionName + "<br />";
            }


            IEnumerable<SelectListItem> RegionList = crDBContext.Regions.Select(c => new SelectListItem
            {
                Value = c.RegionId,
                Text = c.RegionName
            });

            return show;

        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
