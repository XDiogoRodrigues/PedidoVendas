using Microsoft.EntityFrameworkCore;
using PedidoVendas.Models;

namespace PedidoVendas.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }
    public DbSet<ItemDoPedido> ItensDoPedido { get;}
    public DbSet<Pedido> Pedidos { get; set; }
}
