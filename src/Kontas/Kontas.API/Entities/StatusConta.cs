using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kontas.API.Entities
{
    [Index("Nome", Name = "IX_StatusConta_Nome", IsUnique = true)]
    public partial class StatusConta
    {
        public StatusConta()
        {
            Conta = new HashSet<Conta>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Nome { get; set; }

        [InverseProperty("StatusConta")]
        public virtual ICollection<Conta> Conta { get; set; }
    }
}
