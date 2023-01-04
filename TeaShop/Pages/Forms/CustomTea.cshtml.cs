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
            if (Tea.Lavender) TeaPrice += 1;
            if (Tea.Cardamom) TeaPrice += 1;
            if (Tea.Chamomile) TeaPrice += 1;
            if (Tea.Ginger) TeaPrice += 1;
            if (Tea.Mint) TeaPrice += 1;

            return RedirectToPage("/Checkout/Checkout", new { Tea.TeaName, TeaPrice });
        }
    }
}
