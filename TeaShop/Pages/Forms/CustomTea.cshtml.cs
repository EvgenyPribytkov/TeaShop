using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TeaShop.Models;

namespace TeaShop.Pages.Forms
{
    public class CustomTeacshtmlModel : PageModel
    {
        [BindProperty]
        public TeasModel Tea { get; set; }
        public float TeaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            TeaPrice = Tea.BasePrice;
            if (Tea.Size == "250g") TeaPrice += 15;
            else if (Tea.Size == "500g") TeaPrice += 35;
            else if (Tea.Size == "1kg") TeaPrice += 100;

            return RedirectToPage("/Checkout/Checkout", new { Tea.TeaName, TeaPrice });
        }
    }
}
