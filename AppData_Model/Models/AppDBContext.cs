using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppData_Model.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {
            
        }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public virtual DbSet<SanPham>? sanPhams { get; set; }
        public virtual DbSet<Student>? students { get; set; }

        //db

        public virtual DbSet<Account>? accounts { get; set; }
        public virtual DbSet<Bill>? bills { get; set; }
        public virtual DbSet<Bill_Details>? bill_detailss { get; set; }
        public virtual DbSet<Cart>? carts { get; set; }
        public virtual DbSet<Cart_Details>? cart_detailss { get; set; }
        public virtual DbSet<Category>? categories { get; set; }
        public virtual DbSet<Category_Product>? category_detailss { get; set; }
        public virtual DbSet<Comment>? comments { get; set; }
        public virtual DbSet<Coupon>? coupons { get; set; }
        public virtual DbSet<Customer>? customers { get; set; }
        public virtual DbSet<Customer_Coupon>? customer_coupons { get; set; }
        public virtual DbSet<Order>? orders { get; set; }
        public virtual DbSet<Order_Coupon>? order_coupons { get; set; }
        public virtual DbSet<Order_Details>? order_detailss { get; set; }
        public virtual DbSet<Permission>? permissions { get; set; }
        public virtual DbSet<Product>? products { get; set; }
        public virtual DbSet<Review>? reviews { get; set; }
        public virtual DbSet<Role>? roles { get; set; }
        public virtual DbSet<Role_Permission>? role_permissions { get; set; }
        public virtual DbSet<Wishlist>? wishlists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=NET105_WebMVC6_18101;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
