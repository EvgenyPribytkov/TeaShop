using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TeaShop.Data;
using TeaShop.Models;

namespace TeaShop.Pages;

public class OrdersModel : PageModel
{
    public List<TeaOrder> TeaOrders = new List<TeaOrder>();
    private readonly ApplicationDbContext _context;

    public OrdersModel(ApplicationDbContext context)
    {
        _context = context;
    }
    public void OnGet()
    {
        TeaOrders = _context.TeaOrders.ToList();
    }
}
