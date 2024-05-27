using System.ComponentModel.DataAnnotations;

namespace EstoqueAPI.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório!")]
        [MinLength(2, ErrorMessage = "Este campo deve conter pelo menos 2 caracteres")]
        public string NomeProduto { get; set; }
        [Required(ErrorMessage = "Produto está vencido ou a data é inválida!")]
        public DateTime DataValidade { get; set; }
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório!")]
        public int Quantidade { get; set; }
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório!")]
        public int Lote { get; set; }
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório!")]
        public string TipoProduto { get; set; }

        public void Update(string nomeProduto, DateTime dataValidade, int quantidade, int lote, string tipoProduto)
        {
            NomeProduto = nomeProduto;
            DataValidade = dataValidade;
            Quantidade = quantidade;
            Lote = lote;
            TipoProduto = tipoProduto;
        }
    }
}
