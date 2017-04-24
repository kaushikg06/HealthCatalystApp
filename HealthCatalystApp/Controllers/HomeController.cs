using System;
using System.Linq;
using System.Web.Mvc;
using HealthCatalystApp.DAL;

namespace HealthCatalystApp.Controllers
{
    /// <summary>
    /// Controrller that returns the home page,
    /// along with the ajax call used to return search
    /// results.
    /// </summary>
    public class HomeController : Controller
    {
        //variable to hold people database context
        private PeopleContext db = new PeopleContext();


        //returns the view for the homepage
        public ActionResult Index()
        {

            return View();
        }


        /// <summary>
        /// This controller is called to return JSON containing
        /// search restuls form AJAX call.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult SearchResults(string id)
        {
            var people = from m in db.People select m;

            if (!String.IsNullOrEmpty(id))
            {
                people = people.Where(s => s.first_name.Contains(id) || s.last_name.Contains(id));

            }

            //Returns JSON containing search results
            return Json(people.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}