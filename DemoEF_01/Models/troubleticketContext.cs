using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoEF_01.Models
{
    public partial class troubleticketContext : DbContext
    {
        public troubleticketContext()
        {
        }

        public troubleticketContext(DbContextOptions<troubleticketContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Note> Note { get; set; }
        public virtual DbSet<Operatore> Operatore { get; set; }
        public virtual DbSet<OperatoreUtenti> OperatoreUtenti { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<Utente> Utente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-6LUD13E;Database=trouble-ticket;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>(entity =>
            {
                entity.Property(e => e.NoteId)
                    .HasColumnName("noteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataNote)
                    .HasColumnName("dataNote")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkOperId).HasColumnName("fk_operID");

                entity.Property(e => e.FkTicketId).HasColumnName("fk_ticketID");

                entity.Property(e => e.StatoNota)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.TipoNota)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.HasOne(d => d.FkOper)
                    .WithMany(p => p.Note)
                    .HasForeignKey(d => d.FkOperId)
                    .HasConstraintName("FK_Note_Operatore");

                entity.HasOne(d => d.FkTicket)
                    .WithMany(p => p.Note)
                    .HasForeignKey(d => d.FkTicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Note_Ticket");
            });

            modelBuilder.Entity<Operatore>(entity =>
            {
                entity.HasKey(e => e.OperId);

                entity.Property(e => e.OperId)
                    .HasColumnName("OperID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cognome)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OperatoreUtenti>(entity =>
            {
                entity.HasKey(e => e.OperatoriUtentiId);

                entity.Property(e => e.OperatoriUtentiId)
                    .HasColumnName("OperatoriUtentiID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FkOperId).HasColumnName("fk_operID");

                entity.Property(e => e.FkUtentiId).HasColumnName("fk_utentiID");

                entity.HasOne(d => d.FkOper)
                    .WithMany(p => p.OperatoreUtenti)
                    .HasForeignKey(d => d.FkOperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OperatoreUtenti_Operatore");

                entity.HasOne(d => d.FkUtenti)
                    .WithMany(p => p.OperatoreUtenti)
                    .HasForeignKey(d => d.FkUtentiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OperatoreUtenti_Utente");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.Property(e => e.TicketId)
                    .HasColumnName("ticketID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataApertura)
                    .HasColumnName("dataApertura")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkUtentiId).HasColumnName("fk_utentiID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.HasOne(d => d.FkUtenti)
                    .WithMany(p => p.Ticket)
                    .HasForeignKey(d => d.FkUtentiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticket_Utente");
            });

            modelBuilder.Entity<Utente>(entity =>
            {
                entity.HasKey(e => e.UtentiId);

                entity.Property(e => e.UtentiId)
                    .HasColumnName("UtentiID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cognome)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
