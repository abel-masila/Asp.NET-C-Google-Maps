using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoogleMaps.Models;

namespace GoogleMaps.Controllers
{
    public class MapController : Controller
    {
        //
        // GET: /Map/

        public ActionResult Index()
        {
            MapsEntities GE = new MapsEntities();
            return View(GE.Sheet1_.ToList().Take(50));
        }
        [HttpPost]
        public ActionResult Search(string Location)
        {

          MapsEntities GE = new MapsEntities();
            var result = GE.Sheet1_.Where(x => x.Name.StartsWith(Location)).Take(50).ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}
