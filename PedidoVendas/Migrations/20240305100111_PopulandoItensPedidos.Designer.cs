﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PedidoVendas.Context;

#nullable disable

namespace PedidoVendas.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240305100111_PopulandoItensPedidos")]
    partial class PopulandoItensPedidos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("PedidoVendas.Models.ItemDoPedido", b =>
                {
                    b.Property<int>("ItemDoPedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ItemDoPedidoId"));

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.HasKey("ItemDoPedidoId");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItensDoPedido");
                });

            modelBuilder.Entity("PedidoVendas.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PedidoId"));

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("PedidoId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("PedidoVendas.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ProdutoId"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("PedidoVendas.Models.ItemDoPedido", b =>
                {
                    b.HasOne("PedidoVendas.Models.Pedido", "Pedido")
                        .WithMany("ItensDoPedido")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PedidoVendas.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("PedidoVendas.Models.Pedido", b =>
                {
                    b.Navigation("ItensDoPedido");
                });
#pragma warning restore 612, 618
        }
    }
}
