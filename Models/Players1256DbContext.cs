using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppPlayers.Models
{
    public partial class Players1256DbContext : DbContext
    {
        public Players1256DbContext()
        {
        }

        public Players1256DbContext(DbContextOptions<Players1256DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Players { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:players1256server.database.windows.net,1433;Initial Catalog=Players1256Db;Persist Security Info=False;User ID=arkaadmin;Password=Arka123@#$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Player__C5775540C2A59365");

                entity.ToTable("Player");

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("PId");

                entity.Property(e => e.Pname).HasMaxLength(50);

                entity.Property(e => e.Prole).HasMaxLength(50);

                entity.Property(e => e.Pteam)
                    .HasMaxLength(50)
                    .HasColumnName("PTeam");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
