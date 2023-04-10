using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kontas.API.Entities
{
    public partial class Conta
    {
        public Conta()
        {
            ContaPagamentos = new HashSet<ContaPagamento>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descricao { get; set; }
        [Column(TypeName = "date")]
        public DateTime Vencimento { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Valor { get; set; }
        public int StatusContaId { get; set; }
        [Column("APagar")]
        public bool Apagar { get; set; }

        [ForeignKey("StatusContaId")]
        [InverseProperty("Conta")]
        public virtual StatusConta StatusConta { get; set; }
        [InverseProperty("Conta")]
        public virtual ICollection<ContaPagamento> ContaPagamentos { get; set; }
    }
}
