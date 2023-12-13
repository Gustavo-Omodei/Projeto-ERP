using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MiniERP
{
    public partial class erpContext : DbContext
    {
        public erpContext()
        {
        }

        public erpContext(DbContextOptions<erpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Fornecedore> Fornecedores { get; set; } = null!;
        public virtual DbSet<NotaFiscal> NotaFiscals { get; set; } = null!;
        public virtual DbSet<Produto> Produtos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost; initial Catalog=erp;User ID=sa;password=senha1234@;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("clientes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<Fornecedore>(entity =>
            {
                entity.ToTable("fornecedores");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("razaoSocial");
            });

            modelBuilder.Entity<NotaFiscal>(entity =>
            {
                entity.ToTable("notaFiscal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCliente).HasColumnName("id_Cliente");

                entity.Property(e => e.IdProduto).HasColumnName("id_Produto");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.NotaFiscals)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__notaFisca__id_Cl__3E52440B");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.NotaFiscals)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK__notaFisca__id_Pr__3F466844");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.ToTable("produtos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdFornecedor).HasColumnName("id_Fornecedor");

                entity.Property(e => e.TipoProduto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tipoProduto");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("valor");

                entity.HasOne(d => d.IdFornecedorNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.IdFornecedor)
                    .HasConstraintName("FK__produtos__id_For__3B75D760");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
