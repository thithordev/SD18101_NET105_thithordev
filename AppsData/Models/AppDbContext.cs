using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsData.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(){}
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

        // DbSet
        public DbSet<Sinhvien> sinhviens { get; set; }
        public DbSet<Sanpham> sanphams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=SHANGHAIK;
Initial Catalog=NET105_18101;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
