using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Web.Controllers
{
    //[Route("Pizza")]
    public class PizzaController : Controller
    {
        //[Route("Home")]
        public IActionResult Index()
        {
            List<Pizza> pizzas = StaticDB.Pizzas;

            return new JsonResult(pizzas);
        }

        //[Route("Details")]
        public IActionResult Details(int id)
        {
            if (StaticDB.Pizzas.Any(x => x.Id == id))
            {
                Pizza pizza = StaticDB.Pizzas.SingleOrDefault(x => x.Id == id);
                return new JsonResult(pizza);
            } else
            {
                //return new EmptyResult();

                return RedirectToAction("Error", "Home");
            }
        }
    }
}
