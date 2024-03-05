using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PedidoVendas.Models;

public class Produto
{
    [Key]
    public int ProdutoId { get; set; }

    [Required]
    [Display(Name = "Nome do Produto")]
    [StringLength(500)]
    public string Nome { get; set; }

    [Required]
    [Column(TypeName ="decimal(10,2)")]
    [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
    [Display(Name = "Preço do produto")]
    public decimal Preco { get; set; }
}
