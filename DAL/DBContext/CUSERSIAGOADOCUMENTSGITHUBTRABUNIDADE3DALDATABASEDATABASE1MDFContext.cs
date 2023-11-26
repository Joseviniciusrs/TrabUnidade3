using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MODEL;

namespace DAL.DBContext
{
    public partial class CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext : DbContext
    {
        public CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext()
        {
        }

        public CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext(DbContextOptions<CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAluno> TbAlunos { get; set; } = null!;
        public virtual DbSet<TbEquipamento> TbEquipamentos { get; set; } = null!;
        public virtual DbSet<TbFichatr> TbFichatrs { get; set; } = null!;
        public virtual DbSet<TbProfessor> TbProfessors { get; set; } = null!;
        public virtual DbSet<TbRepeticao> TbRepeticaos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\iagoa\\Documents\\GitHub\\TrabUnidade3\\DAL\\database\\Database1.mdf;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAluno>(entity =>
            {
                entity.HasKey(e => e.IdAluno)
                    .HasName("PK__tb_aluno__C19A74F26C8509BB");

                entity.ToTable("tb_aluno");

                entity.Property(e => e.IdAluno).HasColumnName("id_Aluno");

                entity.Property(e => e.Cpf).HasColumnType("text");

                entity.Property(e => e.Ddd)
                    .HasColumnType("text")
                    .HasColumnName("DDD");

                entity.Property(e => e.Email).HasColumnType("text");

                entity.Property(e => e.NomeA).HasColumnType("text");

                entity.Property(e => e.Numero).HasColumnType("text");
            });

            modelBuilder.Entity<TbEquipamento>(entity =>
            {
                entity.HasKey(e => e.IdEquipamento)
                    .HasName("PK__tb_equip__FBC58DC2E10EFEFD");

                entity.ToTable("tb_equipamento");

                entity.Property(e => e.IdEquipamento).HasColumnName("id_Equipamento");

                entity.Property(e => e.NomeEqp).HasColumnType("text");
            });

            modelBuilder.Entity<TbFichatr>(entity =>
            {
                entity.HasKey(e => e.IdFichatr)
                    .HasName("PK__tb_ficha__362063FC8D6BA767");

                entity.ToTable("tb_fichatr");

                entity.Property(e => e.IdFichatr).HasColumnName("id_Fichatr");

                entity.Property(e => e.IdAluno).HasColumnName("id_Aluno");

                entity.Property(e => e.IdProf).HasColumnName("id_Prof");

                entity.HasOne(d => d.IdAlunoNavigation)
                    .WithMany(p => p.TbFichatrs)
                    .HasForeignKey(d => d.IdAluno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aluno");

                entity.HasOne(d => d.IdProfNavigation)
                    .WithMany(p => p.TbFichatrs)
                    .HasForeignKey(d => d.IdProf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_prof");
            });

            modelBuilder.Entity<TbProfessor>(entity =>
            {
                entity.HasKey(e => e.IdProf)
                    .HasName("PK__tb_profe__2E46E6978DF9DDAC");

                entity.ToTable("tb_professor");

                entity.Property(e => e.IdProf).HasColumnName("id_Prof");

                entity.Property(e => e.Cnpj).HasColumnType("text");

                entity.Property(e => e.Ddd)
                    .HasColumnType("text")
                    .HasColumnName("DDD");

                entity.Property(e => e.Email).HasColumnType("text");

                entity.Property(e => e.NomeP).HasColumnType("text");

                entity.Property(e => e.Numero).HasColumnType("text");
            });

            modelBuilder.Entity<TbRepeticao>(entity =>
            {
                entity.HasKey(e => e.IdRepeticao)
                    .HasName("PK__tb_repet__296D8BF1EB9A6D45");

                entity.ToTable("tb_repeticao");

                entity.Property(e => e.IdRepeticao).HasColumnName("id_Repeticao");

                entity.Property(e => e.IdEquipamento).HasColumnName("id_Equipamento");

                entity.Property(e => e.IdFichatr).HasColumnName("id_Fichatr");

                entity.HasOne(d => d.IdEquipamentoNavigation)
                    .WithMany(p => p.TbRepeticaos)
                    .HasForeignKey(d => d.IdEquipamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_eqp");

                entity.HasOne(d => d.IdFichatrNavigation)
                    .WithMany(p => p.TbRepeticaos)
                    .HasForeignKey(d => d.IdFichatr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_fich");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
