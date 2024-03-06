using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PedidoVendas.Context;
using PedidoVendas.Models;
using PedidoVendas.ViewModels;

namespace PedidoVendas.Controllers
{
    public class PedidoController : Controller
    {
        private readonly AppDbContext _context;

        public PedidoController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var pedido = _context.Pedidos.Include(p => p.ItensDoPedido).SingleOrDefault(p => p.PedidoId == 1);

            if (pedido == null)
            {
                return NotFound();
            }
    
            var viewModel = new PedidoViewModel
            {
                ItemPedido = pedido
            };

            return View(viewModel);
        }
    }
}
