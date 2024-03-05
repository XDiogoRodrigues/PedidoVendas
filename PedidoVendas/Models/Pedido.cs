namespace PedidoVendas.Models;

public class Pedido
{
    public int PedidoId { get; set; }
    public string Nome { get; set; }
    public List<ItemDoPedido> ItensDoPedido { get; set; }
}
    