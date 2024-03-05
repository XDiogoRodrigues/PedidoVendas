using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PedidoVendas.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoItensPedidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO ItensDoPedido(ProdutoId,PedidoId) VALUES(4,1)");
            migrationBuilder.Sql("INSERT INTO ItensDoPedido(ProdutoId,PedidoId) VALUES(1,1)");
            migrationBuilder.Sql("INSERT INTO ItensDoPedido(ProdutoId,PedidoId) VALUES(3,1)");
            migrationBuilder.Sql("INSERT INTO ItensDoPedido(ProdutoId,PedidoId) VALUES(1,2)");
            migrationBuilder.Sql("INSERT INTO ItensDoPedido(ProdutoId,PedidoId) VALUES(2,2)");
            migrationBuilder.Sql("INSERT INTO ItensDoPedido(ProdutoId,PedidoId) VALUES(3,3)");
            migrationBuilder.Sql("INSERT INTO ItensDoPedido(ProdutoId,PedidoId) VALUES(1,3)");
            migrationBuilder.Sql("INSERT INTO ItensDoPedido(ProdutoId,PedidoId) VALUES(3,3)");
            migrationBuilder.Sql("INSERT INTO ItensDoPedido(ProdutoId,PedidoId) VALUES(4,3)");
            migrationBuilder.Sql("INSERT INTO ItensDoPedido(ProdutoId,PedidoId) VALUES(1,4)");
            migrationBuilder.Sql("INSERT INTO ItensDoPedido(ProdutoId,PedidoId) VALUES(2,4)");
            migrationBuilder.Sql("INSERT INTO ItensDoPedido(ProdutoId,PedidoId) VALUES(3,4)");
            migrationBuilder.Sql("INSERT INTO ItensDoPedido(ProdutoId,PedidoId) VALUES(4,4)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
