using SEDC.PizzaApp.Web.Models.Domain;
using SEDC.PizzaApp.Web.Models.ViewModels;



namespace SEDC.PizzaApp.Web.Models.Mapper
{
    public static class PizzaMapper
    {
        //public static OrderDetailsViewModel OrderToOrderDetailsViewModel(Order order)

        public static PizzaDetailsViewModel PizzaToPizzaViewModel(this Pizza pizza)
        {
            return new PizzaDetailsViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                PizzaSize = pizza.PizzaSize,

                Price = pizza.HasExtras ? pizza.Price + 10 : pizza.Price

            };
        }
    }
}
