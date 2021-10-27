using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace crud_cep.Models
{
    public partial class db_selecao_imdbContext : DbContext
    {
        public db_selecao_imdbContext()
        {
        }

        public db_selecao_imdbContext(DbContextOptions<db_selecao_imdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cep> Ceps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=no-db-dev-101.negocieonline.com.br;Database=db_selecao_imdb;Username=test;Password=Sacapp@2020");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Cep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ceps");

                entity.Property(e => e.Bairro)
                    .HasColumnType("character varying")
                    .HasColumnName("bairro");

                entity.Property(e => e.Cep1)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("cep");

                entity.Property(e => e.Ddd)
                    .HasColumnType("character varying")
                    .HasColumnName("ddd");

                entity.Property(e => e.Gia)
                    .HasColumnType("character varying")
                    .HasColumnName("gia");

                entity.Property(e => e.Ibge)
                    .HasColumnType("character varying")
                    .HasColumnName("ibge");

                entity.Property(e => e.Localidade)
                    .HasColumnType("character varying")
                    .HasColumnName("localidade");

                entity.Property(e => e.Logradouro)
                    .HasColumnType("character varying")
                    .HasColumnName("logradouro");

                entity.Property(e => e.Siafi)
                    .HasColumnType("character varying")
                    .HasColumnName("siafi");

                entity.Property(e => e.Uf)
                    .HasColumnType("character varying")
                    .HasColumnName("uf");
            });

            modelBuilder.HasSequence("cep_id_seq");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
