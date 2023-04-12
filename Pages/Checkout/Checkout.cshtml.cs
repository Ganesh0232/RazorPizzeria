using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Checkout
{  
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        
        public string ImageTitle { get; set; }
        public CheckoutModel(ApplicationDbContext context)
        {
            _context=context;
            
        }
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ PizzaName="Margerita"},
           new PizzasModel(){ PizzaName="Carbonara"},
           new PizzasModel(){ PizzaName="Margerita"},
   new PizzasModel(){ PizzaName="Hawaiin"},
      new PizzasModel(){ PizzaName="italian"},
         new PizzasModel(){ PizzaName="MeatFeast"},
            new PizzasModel(){ PizzaName="Mushroom"},
               new PizzasModel(){ PizzaName="Paneer"},
     new PizzasModel(){ PizzaName="Pepperoni"},
     new PizzasModel(){ PizzaName="Seafood"},

        };

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Regular pizza ";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";

            }
           

            PizzaOrder pizzaOrder = new PizzaOrder();

            pizzaOrder.BasePrice = PizzaPrice;
            pizzaOrder.PizzaName = PizzaName;
            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();
        }
        //public IActionResult OnGet()
        //{

        //    return RedirectToPage("/Checkout/ThankYou");
        //}
    }
}
