using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
              new PizzasModel(){ImageTitle="Margerita",PizzaName="Margerita",BasePrice=99,TomatoSauce=true,Cheese=true,FinalPrice=199},
              new PizzasModel(){ImageTitle="Bolognese",PizzaName="Bolognese",BasePrice=99,TomatoSauce=true,Cheese=true,FinalPrice=999},
              new PizzasModel(){ImageTitle="Carbonara",PizzaName="Carbonara",BasePrice=99,TomatoSauce=true,Cheese=true,FinalPrice=599},
          //    new PizzasModel(){ImageTitle="italian",PizzaName="italian",BasePrice=99,TomatoSauce=true,Cheese=true,FinalPrice=899},
          //    new PizzasModel(){ImageTitle="italian",PizzaName="italian",BasePrice=199,TomatoSauce=true,Cheese=true,FinalPrice=699},
              new PizzasModel(){ImageTitle="Hawaiian",PizzaName="Hawaiian",BasePrice=99,TomatoSauce=true,Cheese=true,FinalPrice=499},
              new PizzasModel(){ImageTitle="MeatFeast",PizzaName="MeatFeast",BasePrice=99,TomatoSauce=true,Cheese=true,FinalPrice=799},
              new PizzasModel(){ImageTitle="Mushroom",PizzaName="Mushroom",BasePrice=99,TomatoSauce=true,Cheese=true,FinalPrice=099},
              new PizzasModel(){ImageTitle="Pepperoni",PizzaName="Pepperoni",BasePrice=99,TomatoSauce=true,Cheese=true,FinalPrice=399},
              new PizzasModel(){ImageTitle="Seafood",PizzaName="Seafood",BasePrice=99,TomatoSauce=true,Cheese=true,FinalPrice=1099},
              new PizzasModel(){ImageTitle="Paneer",PizzaName="Chicken",BasePrice=99,TomatoSauce=true,Cheese=true,FinalPrice=299},


        };


        public void OnGet()
        {
        }
    }
}
