namespace PedidoVendas.Models;

public class ItemDoPedido
{
    public int ItemDoPedidoId { get; set; }
    public int ProdutoId { get; set; }
    public int PedidoId { get; set; }
    public virtual Produto Produto{ get; set; }
    public virtual Pedido Pedido { get; set; }


}
