using Microsoft.EntityFrameworkCore;
using Auth.Domain;

using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Linq;
using System.Threading.Tasks;
using Auth.Database.Maps;

namespace Auth.Data
{
    public class AuthDbContext:DbContext, IUnitOfWork
    {
        
        
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }

        public DbSet<Application> Application { get; set; }
        public DbSet<Customer> Customer{ get; set; }
        public AuthDbContext()
        {

        }
        public AuthDbContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=DESKTOP-JFUK3LG\\SQLEXPRESS;database=Auth;Trusted_Connection=True;");
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(e => e.ClrType == typeof(string))))
                property.SetColumnType("VarChar(100)");

            

            modelBuilder.ApplyConfiguration(new MapApplication());
            modelBuilder.ApplyConfiguration(new MapCustomer());
            modelBuilder.ApplyConfiguration(new MapUser());
            modelBuilder.ApplyConfiguration(new MapRole());

        }

        public  bool Commit(bool logicalDelete = false)
        {
            foreach(var entry in ChangeTracker.Entries().Where( p=> p.GetType().GetProperties().Where(p=>p.Name == "CreatedOn" || p.Name == "UpdatedOn" || p.Name == "DeletedOn") != null)){
                if(entry.State == EntityState.Added)
                {
                    entry.Property("CreatedOn").CurrentValue = DateTime.Now; 
                }
                if(entry.State == EntityState.Modified)
                {
                    if (logicalDelete == false)
                    {
                        entry.Property("CreatedOn").IsModified = false;
                        entry.Property("UpdatedOn").CurrentValue = DateTime.Now;
                    }
                    else
                    {
                        entry.Property("CreatedOn").IsModified = false;
                        entry.Property("DeletedOn").CurrentValue = DateTime.Now;
                    }
                }
            }
            return  base.SaveChanges() > 0;
        }

        
    }
}
