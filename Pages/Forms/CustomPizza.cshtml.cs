using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.Tuna) PizzaPrice += 99;
            if (Pizza.Cheese) PizzaPrice += 55;
            if (Pizza.Paneer) PizzaPrice += 85;
            if (Pizza.Chicken) PizzaPrice += 200;
            if (Pizza.Ham) PizzaPrice += 25;
            if (Pizza.Mushroom) PizzaPrice += 65;
            if (Pizza.Peperoni) PizzaPrice += 199;
            if (Pizza.TomatoSauce) PizzaPrice += 25;
          
            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName,PizzaPrice});

        }   
    }
}
