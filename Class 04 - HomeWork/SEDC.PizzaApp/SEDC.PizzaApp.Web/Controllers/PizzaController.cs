using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Web.Models;
using SEDC.PizzaApp.Web.Models.Mapper;
using SEDC.PizzaApp.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Web.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {

            List<PizzaViewModel> pizzaViewList = new List<PizzaViewModel>();

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

        public IActionResult Details(int id)
        {
            if (StaticDB.Pizzas.Any(x => x.Id == id))
            {
                List<PizzaViewModel> pizzaViewModel = new List<PizzaViewModel>();

                Pizza pizza = StaticDB.Pizzas.SingleOrDefault(x => x.Id == id);
                pizzaViewModel.Add( pizza.PizzaToPizzaViewModel());

                ViewBag.Pizza = pizzaViewModel;
                ViewData.Add("Title", "Pizza detils");

                return View(pizzaViewModel);
            }
            else
            {
                return new EmptyResult();
            }
        }
    }
}
