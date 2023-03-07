using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TeaShop.Models;

namespace TeaShop.Pages
{
    public class TeaModel : PageModel
    {
        public List<Models.Tea> teaDB = new List<Models.Tea>()
        {
            new Models.Tea()
            {
                ImageTitle="Relax", TeaName="Relax", BasePrice = 30, Chamomile = true, Lavender = true, Cardamom = false, Cinnamon = false, Ginger = false, Mint = false, FinalPrice = 32
            },
            new Models.Tea()
            {
                ImageTitle="Immune boost", TeaName="Immune boost", BasePrice = 30, Chamomile = false, Lavender = false, Cardamom = true, Cinnamon = false, Ginger = true, Mint = false, FinalPrice = 32
            },
            new Models.Tea()
            {
                ImageTitle="Magic Forest", TeaName="Magic Forest", BasePrice = 30, Chamomile = false, Lavender = true, Cardamom = true, Cinnamon = false, Ginger = false, Mint = false, FinalPrice = 32
            }
        };
        public void OnGet()
        {
        }
    }
}
