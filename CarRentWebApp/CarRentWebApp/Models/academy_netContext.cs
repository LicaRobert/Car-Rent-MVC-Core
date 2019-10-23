using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRentWebApp.Models
{
    public partial class academy_netContext : IdentityDbContext
    {
        public academy_netContext()
        {
        }

        public academy_netContext(DbContextOptions<academy_netContext> options)
            : base(options)
        {
         
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=academy_net;Trusted_Connection=True;");
            }
        }


        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<CarRent> CarRent { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }

        public virtual DbSet<City> City { get; set; }

        public IEnumerable<object> Suppliers { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cars>(entity =>
            {
                entity.HasKey(e => e.CarId);

                entity.Property(e => e.CarId).HasColumnName("CarID");

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PricePerDay).HasColumnType("money");
            });

            modelBuilder.Entity<CarRent>(entity =>
            {

                entity.HasKey(e => e.CarRentID);

                entity.Property(e => e.CarRentID).HasColumnName("CarRentID");

                entity.Property(e => e.ClientID)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CarModel)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

            });

            modelBuilder.Entity<City>(entity =>
            {

                entity.HasKey(e => e.CityID);

                entity.Property(e => e.CityID).HasColumnName("CityID");


                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CostumerId);

                entity.Property(e => e.CostumerId).HasColumnName("CostumerID");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                   .IsRequired()
                   .HasMaxLength(50)
                   .IsUnicode(false);

                entity.Property(e => e.ConfirmPassword)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);
            });
        }
    }
}
