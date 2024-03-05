using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PedidoVendas.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(Nome,Preco) VALUES('Celular Samsung', 2500.99)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome,Preco) VALUES('Celular LG', 1500.99)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome,Preco) VALUES('Celular Motorola',1200.99)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome,Preco) VALUES('Notebook Dell', 4500.99)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
