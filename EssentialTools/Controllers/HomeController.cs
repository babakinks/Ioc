using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EssentialTools.Models;
using Ninject;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private Product[] products =
        {
            new Product {Name = "Kayak", Category = "Watersports", Price = 257M},
            new Product {Name = "Lifejacket", Category = "Lifejacket", Price = 48.95M},
            new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.5M},
            new Product {Name = "Corner Flag", Category = "Soccer", Price = 35.4M}
        };

        private IValueConverter calc;

        public HomeController(IValueConverter calcParam)
        {
            calc = calcParam;
        }
        public ActionResult Index()
        {
            //IKernel ninjectKernel = new StandardKernel();
            //ninjectKernel.Bind<IValueConverter>().To<LinqValueCalculator>();

            ////IValueConverter calc = new LinqValueCalculator();
            //IValueConverter calc = ninjectKernel.Get<IValueConverter>();

            ShoppingCart cart = new ShoppingCart(calc) {Products = products};
            decimal totalValue = cart.CalculateProductTotal();

            return View(totalValue);
        }

    }
}
