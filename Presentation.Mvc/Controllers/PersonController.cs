using Presentation.Mvc.Models;
using System.Linq;
using System.Web.Mvc;
using Application.Persons.Queries;

namespace Presentation.Mvc.Controllers
{
    public class PersonController : Controller
    {
        private readonly IGetPersonsQuery _GetPersonsQuery;

        public PersonController(IGetPersonsQuery getPersonsQuery)
        {
            _GetPersonsQuery = getPersonsQuery;
        }

        // GET: Person
        public ActionResult Index()
        {
            ViewData.Model = _GetPersonsQuery.Query().Select(p => new PersonModel(p)).ToList();

            return View();
        }
    }
}