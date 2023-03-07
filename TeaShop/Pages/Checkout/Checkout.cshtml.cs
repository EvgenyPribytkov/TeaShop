using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TeaShop.Data;
using TeaShop.Models;

namespace TeaShop.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public string TeaName { get; set; }
        public float TeaPrice { get; set; }
        public string ImageTitle { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(TeaName))
            {
                TeaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }
            TeaOrder teaOrder = new TeaOrder();
            teaOrder.TeaName = TeaName;
            teaOrder.BasePrice = TeaPrice;

            _context.TeaOrders.Add(teaOrder);
            _context.SaveChanges();
        }
    }
}
