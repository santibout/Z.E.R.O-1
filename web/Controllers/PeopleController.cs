using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Z.E.R.O_1.web.Controllers
{
    [RoutePrefix("People")]
    public class PeopleController : Controller
    {
        [Route]
        public ActionResult Index()
        {
            return View();
        }
        [Route("manage")]
        [Route("{id:int}/edit")]
        public ActionResult Manage(int id = 0)
        {
            ItemViewModel<int> model = new ItemViewModel<int>();
            model.Item = id;
            return View(model);
        }
    }
}