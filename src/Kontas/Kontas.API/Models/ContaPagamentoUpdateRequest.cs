namespace Kontas.API.Models
{
    public class ContaPagamentoUpdateRequest
    {
        public int ContaId { get; internal set; }
        public decimal Valor { get; internal set; }
        public DateTime Data { get; internal set; }
    }
}