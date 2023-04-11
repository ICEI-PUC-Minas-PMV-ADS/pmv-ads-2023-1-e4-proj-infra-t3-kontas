using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Kontas.API.Entities
{
    public partial class KontasDBContext : DbContext
    {
        public KontasDBContext()
        {
        }

        public KontasDBContext(DbContextOptions<KontasDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Conta> Conta { get; set; }
        public virtual DbSet<ContaPagamento> ContaPagamento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:KontasDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContaPagamento>(entity =>
            {
                entity.HasOne(d => d.Conta)
                    .WithMany(p => p.ContaPagamento)
                    .HasForeignKey(d => d.ContaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContaPagamento_Conta");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
