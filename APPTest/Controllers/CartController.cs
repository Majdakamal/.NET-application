using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http; // Add this line
using APPTest.Models;
using APPTest.Data;
namespace APPTest.Controllers
{
    // CartController.cs
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Http;

    public class CartController : Controller
    {
        private readonly ASP_MVC_Context _context;

        public CartController(ASP_MVC_Context context)
        {
            _context = context;
        }
        public IActionResult Cart()
        {
            var cart = HttpContext.Session.Get<Cart>("Cart") ?? new Cart();
            return View(cart.Items);
        }

        [HttpPost]
        public IActionResult AddToCart(int potteryId)
        {
            var pottery = _context.Pottery.Find(potteryId);

            if (pottery != null)
            {
                var cart = HttpContext.Session.Get<Cart>("Cart") ?? new Cart();
                cart.Items.Add(new CartItem
                {
                    PotteryId = pottery.Id,
                    PotteryTitle = pottery.Title,
                    PotteryPrice = pottery.Price,
                    Quantity = 1 // You can set the default quantity as needed
                });

                HttpContext.Session.Set("Cart", cart);

                return RedirectToAction("Index", "Potteries");
            }

            return NotFound();
        }
       
    }

}
