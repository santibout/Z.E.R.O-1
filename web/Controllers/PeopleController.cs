using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Z.E.R.O_1.web.Controllers
{
    [RoutePrefix("people")]
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
            ItemResponse<int> model = new ItemResponse<int>();
            model.Item = id;
            return View(model);
        }
    }
}