using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PedidoVendas.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoPedidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Pedidos(Nome) VALUES('Diogo Rodrigues')");
            migrationBuilder.Sql("INSERT INTO Pedidos(Nome) VALUES('Diego Rodrigues')");
            migrationBuilder.Sql("INSERT INTO Pedidos(Nome) VALUES('Douglas Rodrigues')");
            migrationBuilder.Sql("INSERT INTO Pedidos(Nome) VALUES('Daiane Rodrigues')");
            migrationBuilder.Sql("INSERT INTO Pedidos(Nome) VALUES('Daniela Rodrigues')");
            migrationBuilder.Sql("INSERT INTO Pedidos(Nome) VALUES('Roberta Rodrigues')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
