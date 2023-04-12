using System.ComponentModel.DataAnnotations;

namespace Kontas.API.Models
{
    public class ContaPagamentoAddRequest
    {
        [Required(ErrorMessage = "O campo ContaId é obrigatório!")]
        public int ContaId { get; internal set; }
        [Required(ErrorMessage = "O campo Valor é obrigatório!")]
        public decimal Valor { get; internal set; }
        [Required(ErrorMessage = "O campo Data é obrigatório!")]
        public DateTime Data { get; internal set; }
    }
}