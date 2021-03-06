using EF_Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Demo.Context
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=ef_demo;User Id=sa;Password=reallyStrongPwd123;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            DefineColumns(modelBuilder);
            SeedData(modelBuilder);
        }

        private void DefineColumns(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
             .Property(p => p.ChargeAmount)
             .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Order>()
             .Property(p => p.PayedAmount)
             .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Product>()
            .Property(p => p.Cost)
            .HasColumnType("decimal(18,2)");
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 1,
                Name = "Emmanuel Toledo",
            });

            modelBuilder.Entity<Order>().HasData(new Order
            {
                ChargeAmount = 40m,
                CustomerId = 1,
                Number = "12345Fx",
                OrderId = 1,
                PayedAmount = 40m,
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Cost = 20m,
                Name = "Mario Kart 8",
                ProductId = 1,
            },
            new Product
            {
                Cost = 20m,
                Name = "Mario 3D All Stars",
                ProductId = 2,
            });
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
