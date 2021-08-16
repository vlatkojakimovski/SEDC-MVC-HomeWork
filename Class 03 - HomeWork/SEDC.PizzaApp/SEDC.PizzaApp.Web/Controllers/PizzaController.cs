using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Web.Models;
using SEDC.PizzaApp.Web.Models.Domain;
using SEDC.PizzaApp.Web.Models.Mapper;
using SEDC.PizzaApp.Web.Models.ViewModels;

namespace SEDC.PizzaApp.Web.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<PizzaDetailsViewModel> pizzaViewList = new List<PizzaDetailsViewModel>();

            StaticDB.Pizzas.ForEach(x => pizzaViewList.Add(x.PizzaToPizzaViewModel()));
            
            ViewData.Add("Title", "Pizza Home Page");
            ViewData.Add("NumberOfApp", 12);

            var firstPizza = StaticDB.Pizzas.First();
            //ViewData.Add("Pizza", firstPizza);

            ViewBag.Name = "SEDC Academy";
            ViewBag.NumberOfPizzas = 2;
            ViewBag.Pizza = firstPizza;

            return View(pizzaViewList);
        }

        public IActionResult Details (int id)
        {
            if (StaticDB.Pizzas.Any(x => x.Id == id))
            {
                Pizza pizza = StaticDB.Pizzas.SingleOrDefault(x => x.Id == id);
                PizzaDetailsViewModel pizzaViewModel = pizza.PizzaToPizzaViewModel();

                ViewBag.pizzaViewBag = pizzaViewModel;
                ViewData["Title"] =pizza.Name;

                return View();
            } else
            {
                return new EmptyResult();
            }
        }
    }
}
