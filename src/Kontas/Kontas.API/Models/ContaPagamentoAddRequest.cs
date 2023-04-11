namespace Kontas.API.Models
{
    public class ContaPagamentoAddRequest
    {
        public int ContaId { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    }
}