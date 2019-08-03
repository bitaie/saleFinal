using Microsoft.EntityFrameworkCore;

using Sale.Domain.Customers;
using Sale.Domain.Invoices;
using Sale.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sale.Infrastructure.EntityFramework
{
    public class AppDbContext : DbContext
    {
        private object connection;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //options.UseSqlServer(connection, b => b.MigrationsAssembly("Sale.ApplicationService"));

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // modelBuilder.Entity<Invoice>().HasMany<Item>(x=>x.Entities).WithOne(x=>x.).HasForeignKey(x=>x.Invoice)
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
       
    }

}
