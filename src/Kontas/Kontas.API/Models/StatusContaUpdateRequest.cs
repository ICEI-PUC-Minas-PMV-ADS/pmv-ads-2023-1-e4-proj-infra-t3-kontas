using System.ComponentModel.DataAnnotations;

namespace Kontas.API.Models
{
    public class StatusContaUpdateRequest
    {
        [Required]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Id é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage ="Id deve ser maior que zero!")]
        public int Id { get; set; }
    }
}
