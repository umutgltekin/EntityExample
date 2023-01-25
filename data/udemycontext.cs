using ConsoleApp5.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.data
{
    public class udemycontext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<saleHistory> sales{ get; set; }
        public DbSet<ProductDetail> productDetails { get; set; }
        public DbSet<categoryProduct> categoryProducts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine);//yapılan crud işlemlerinin nasıl bir sorgu ile gönderildiğini görürüz
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;database=ConsoleApp5;integrated security=true;");
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().ToTable(name: "Products");
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName("product");
            modelBuilder.Entity<Product>().Property(x => x.Name).HasMaxLength(10);
            modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<saleHistory>().HasOne(x => x.product).WithMany(x => x.sale).HasForeignKey(x => x.ProductId);//one to many 
            modelBuilder.Entity<Product>().HasOne(x => x.productDetail).WithOne(x => x.product).HasForeignKey<ProductDetail>(x=> x.ProductId);//one to one
            modelBuilder.Entity<categoryProduct>().HasOne(x => x.product).WithMany(x => x.categoryProducts).HasForeignKey(x => x.ProductId);//many to many
            modelBuilder.Entity<categoryProduct>().HasOne(x => x.category).WithMany(x => x.categoryProducts).HasForeignKey(x => x.ProductId);//many to many



        }
    }
}
