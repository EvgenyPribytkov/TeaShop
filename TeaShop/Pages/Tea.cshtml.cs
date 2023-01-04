using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TeaShop.Models;

namespace TeaShop.Pages
{
    public class TeaModel : PageModel
    {
        public List<TeasModel> teaDB = new List<TeasModel>()
        {
            new TeasModel()
            {
                ImageTitle="Relax", TeaName="Relax", BasePrice = 30, Chamomile = true, Lavender = true, Cardamom = false, Cinnamon = false, Ginger = false, Mint = false, FinalPrice = 32
            },
            new TeasModel()
            {
                ImageTitle="Immune boost", TeaName="Immune boost", BasePrice = 30, Chamomile = false, Lavender = false, Cardamom = true, Cinnamon = false, Ginger = true, Mint = false, FinalPrice = 32
            }
        };
        public void OnGet()
        {
        }
    }
}
