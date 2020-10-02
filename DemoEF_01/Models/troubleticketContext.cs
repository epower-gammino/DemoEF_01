using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoEF_01.Models
{
    public partial class troubleticketContext : DbContext
    {
        public troubleticketContext(DbContextOptions<troubleticketContext> options) : base(options)
        {
        }

        //public troubleticketContext(DbContextOptions<troubleticketContext> options)
        //{
        //}

        public virtual DbSet<Note> Note { get; set; }
        public virtual DbSet<Operatore> Operatore { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<Utente> Utente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning to protect potentially sensitive information in your connection string, you should move it out of source code. see http://go.microsoft.com/fwlink/?linkid=723263 for guidance on storing connection strings.
//                optionsbuilder.usesqlserver("server=desktop-6lud13e;;database=trouble-ticket;trusted_Connection=True;");
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
