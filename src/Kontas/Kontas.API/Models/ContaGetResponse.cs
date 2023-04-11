namespace Kontas.API.Models
{
    public class ContaGetResponse
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Valor { get; set; }
        public bool Apagar { get; set; }
    }
}