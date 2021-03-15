using DataAccess.Models;
using SovosAssessmentMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using static DataAccess.Logic.CaseProcessor;

namespace SovosAssessmentMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GenerateDatatableData(DatatableModel datatableModel)
        {
            var results = new List<CaseViewModel>();
            var mapperHolder = AutoMapper.AutoMapperConfig.Mapper.Map<List<CaseModel>, List<CaseViewModel>>(LoadCases());
            results = mapperHolder;

            return Json(new
            {
                recordsTotal = results.Count,
                recordsFiltered = 0,
                data = results
            });
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}