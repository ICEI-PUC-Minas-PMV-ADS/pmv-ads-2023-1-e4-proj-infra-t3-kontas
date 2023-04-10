using Kontas.API.Entities;

namespace Kontas.API.Models
{
    public class ContaResponse
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; }
        public string Tipo { get; set; }
    }
}
