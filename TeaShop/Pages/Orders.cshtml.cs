using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TeaShop.Data;
using TeaShop.Models;
using TeaShop.Services;

namespace TeaShop.Pages;

public class OrdersModel : PageModel
{
    private TeaOrdersRepository _teaOrdersRepository { get; set; }
    public List<TeaOrder> TeaOrders = new List<TeaOrder>();

    public OrdersModel(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("TeaShopMongoDB");
        _teaOrdersRepository = new TeaOrdersRepository(connectionString);
    }

    public async Task OnGetAsync()
    {
        TeaOrders = await _teaOrdersRepository.GetAllTeaOrders();
    }
}
