using P2.Products;
using P2.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProductsClient productsClient = new ProductsClient();
            Product [] products = productsClient.GetAll();

            UsersClient usersClient = new UsersClient();
            User [] users = usersClient.GetAll();
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