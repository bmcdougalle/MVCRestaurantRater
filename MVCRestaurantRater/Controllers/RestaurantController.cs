using MVCRestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRestaurantRater.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantDBContext _db = new RestaurantDBContext();
        // GET: Restaurant
        public ActionResult Index()
        {
            return View(_db.Restaurants.ToList());
        }
    }
}