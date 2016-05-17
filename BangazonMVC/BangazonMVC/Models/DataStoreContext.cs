using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BangazonMVC.Models
{
    public class DataStoreContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerOrder> CustomerOrder { get; set; }
        //public DbSet<OrderProduct> OrderProduct { get; set; }
        public DbSet<PaymentOption> PaymentOption { get; set; }
        public DbSet<Product> Product { get; set; }
        //public DbSet<ProductType> ProductType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .ToTable("Customer")
                .HasKey(c => c.IdCustomer);

            modelBuilder.Entity<CustomerOrder>()
                .ToTable("CustomerOrder")
                .HasKey(o => o.IdCustomerOrder);

            //modelBuilder.Entity<OrderProduct>()
            //    .ToTable("OrderProduct")
            //    .HasKey(op => op.IdOrderProducts);

            modelBuilder.Entity<PaymentOption>()
                .ToTable("PaymentOption")
                .HasKey(po => po.IdPaymentOption);

            modelBuilder.Entity<Product>()
                .ToTable("Product")
                .HasKey(p => p.IdProduct);

            //modelBuilder.Entity<ProductType>()
            //    .ToTable("ProductType")
            //    .HasKey(pt => pt.IdProductType);
        }
}
}