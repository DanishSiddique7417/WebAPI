using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WenRepository.Entity;

namespace WenRepository
{
    public  class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          

        }
        public DbSet<TblUser> tblUsers { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Employee> Employee { get; set; }
        
        public DbSet<Testing11> Testing11 { get; set; }
        public DbSet<MasterTable> MasterTable { get; set; }
        public DbSet<MasterTable1> MasterTable1 { get; set; }


    }
}
