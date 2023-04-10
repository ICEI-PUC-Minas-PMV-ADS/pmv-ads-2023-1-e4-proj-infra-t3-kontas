using System.ComponentModel.DataAnnotations;

namespace Kontas.API.Models
{
    public class StatusContaAddRequest
    {
        [Required(ErrorMessage = "Nome do status é obrigatório!")]
        public string Nome { get; set; }

    }
}
