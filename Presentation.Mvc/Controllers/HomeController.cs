using Application.Persons;
using Application.Persons.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetPersonsQuery _GetPersonsQuery;

        public ActionResult Index()
        {
            List<IPerson> persons = _GetPersonsQuery.Query().ToList();

            return View();
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