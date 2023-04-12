using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kontas.API.Models
{
    public class ContaAddRequest
    {
        [Required(ErrorMessage = "O campo Descricao é obrigatório!")]
        [StringLength(50, ErrorMessage = "O campo Descricao deve ter no máximo 50 caracteres.")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O campo Vencimento é obrigatório!")]
        public DateTime Vencimento { get; set; }
        [Required(ErrorMessage = "O campo Valor é obrigatório!")]
        public decimal Valor { get; set; }
        [Required(ErrorMessage = "O campo Apagar é obrigatório!")]
        public bool Apagar { get; set; }
    }
}