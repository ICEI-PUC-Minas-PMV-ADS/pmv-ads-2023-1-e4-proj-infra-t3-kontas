using System.ComponentModel.DataAnnotations;

namespace Kontas.API.Models
{
    public class ContaUpdateRequest
    {
        [Required(ErrorMessage = "O campo Id é obrigatório!")]
        public int Id { get; set; }
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