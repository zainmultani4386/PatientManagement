using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PatientManagement.Models
{
    public partial class PatientManagementContext : DbContext
    {
        public PatientManagementContext()
        {
        }

        public PatientManagementContext(DbContextOptions<PatientManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Gpdetails> Gpdetails { get; set; }
        public virtual DbSet<PatientDetail> PatientDetail { get; set; }
        public virtual DbSet<PatientNextOfKin> PatientNextOfKin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=HP\\SQLExpress;Database=PatientManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gpdetails>(entity =>
            {
                entity.ToTable("GPDetails");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Gpcode).HasColumnName("GPCode");

                entity.Property(e => e.Gpinitials)
                    .HasColumnName("GPInitials")
                    .HasMaxLength(50);

                entity.Property(e => e.Gpphone)
                    .HasColumnName("GPPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.Gpsurname)
                    .HasColumnName("GPSurname")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");
            });

            modelBuilder.Entity<PatientDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.ForeName).HasMaxLength(50);

                entity.Property(e => e.Gpcode)
                    .HasColumnName("GPCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Gpinitials)
                    .HasColumnName("GPInitials")
                    .HasMaxLength(50);

                entity.Property(e => e.Gpphone)
                    .HasColumnName("GPPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.Gpsurname)
                    .HasColumnName("GPSurname")
                    .HasMaxLength(10);

                entity.Property(e => e.HomeTelePhoneNumber).HasMaxLength(50);

                entity.Property(e => e.NokAddressLine1).HasMaxLength(50);

                entity.Property(e => e.NokAddressLine2).HasMaxLength(50);

                entity.Property(e => e.NokAddressLine3).HasMaxLength(50);

                entity.Property(e => e.NokAddressLine4).HasMaxLength(50);

                entity.Property(e => e.NokName).HasMaxLength(50);

                entity.Property(e => e.NokPostcode).HasMaxLength(50);

                entity.Property(e => e.NokRelationShipCode).HasMaxLength(50);

                entity.Property(e => e.SexCode).HasMaxLength(10);

                entity.Property(e => e.SurName).HasMaxLength(50);
            });

            modelBuilder.Entity<PatientNextOfKin>(entity =>
            {
                entity.HasKey(e => e.KinId);

                entity.Property(e => e.KinId)
                    .HasColumnName("KinID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NokAddressLine1).HasMaxLength(50);

                entity.Property(e => e.NokAddressLine2).HasMaxLength(50);

                entity.Property(e => e.NokAddressLine3).HasMaxLength(50);

                entity.Property(e => e.NokAddressLine4).HasMaxLength(50);

                entity.Property(e => e.NokName).HasMaxLength(50);

                entity.Property(e => e.NokPostcode).HasMaxLength(50);

                entity.Property(e => e.NokRelationshipCode).HasMaxLength(50);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");
            });
        }
    }
}
