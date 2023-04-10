using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kontas.API.Entities
{
    [Table("ContaPagamento")]
    public partial class ContaPagamento
    {
        [Key]
        public int Id { get; set; }
        public int ContaId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Valor { get; set; }
        [Column(TypeName = "date")]
        public DateTime Data { get; set; }

        [ForeignKey("ContaId")]
        [InverseProperty("ContaPagamentos")]
        public virtual Conta Conta { get; set; }
    }
}
