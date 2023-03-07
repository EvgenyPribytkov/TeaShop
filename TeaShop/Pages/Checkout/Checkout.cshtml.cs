using Microsoft.AspNetCore.Mvc.RazorPages;
using TeaShop.Services;
using Microsoft.Extensions.Configuration;
using TeaShop.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Diagnostics.Metrics;

namespace TeaShop.Pages.Checkout
{
    public class CheckoutModel : PageModel
    {
        private TeaOrdersRepository TeaOrdersRepository { get; set; }

        public CheckoutModel(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("TeaShopMongoDB");
            TeaOrdersRepository = new TeaOrdersRepository(connectionString);
        }

        public string TeaName { get; set; }
        public float TeaPrice { get; set; }
        public string ImageTitle { get; set; }

        public async void OnGet(string teaName, float teaPrice)
        {
            if (string.IsNullOrWhiteSpace(TeaName))
            {
                TeaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            TeaName = teaName;
            TeaPrice = teaPrice;
            ImageTitle = "Create";

            TeaOrder teaOrder = new TeaOrder
            {
                TeaName = TeaName,
                BasePrice = TeaPrice
            };
            await TeaOrdersRepository.InsertTeaOrder(teaOrder);
        }
    }
}
