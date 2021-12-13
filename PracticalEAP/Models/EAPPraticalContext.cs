using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PracticalEAP.Models
{
    public partial class EAPPraticalContext : DbContext
    {
     
        public EAPPraticalContext(DbContextOptions<EAPPraticalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.SutdentId)
                    .HasName("PK__Employee__2780FD4CE234B269");

                entity.ToTable("Employee");

                entity.Property(e => e.SutdentId).HasColumnName("SutdentID");

                entity.Property(e => e.Email)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirtName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
