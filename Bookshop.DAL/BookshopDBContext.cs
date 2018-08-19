using Bookshop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Security.Principal;

namespace Bookshop.DAL
{
    public class BookshopDBContext : DbContext
    {
        public BookshopDBContext()
        {
        }

        public BookshopDBContext(DbContextOptions<BookshopDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Library> Libraries { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = @"Server=(localDb)\MSSQLLocalDB;Database=Bookshop;Trusted_Connection=True;ConnectRetryCount=0";
            
            //optionsBuilder.UseSqlServer(GetConnectionString());
            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries<Entity>()
                .Where(x => x.State == EntityState.Modified))
            {
                item.Entity.Modified = DateTime.Now;
                item.Entity.ModifiedBy = WindowsIdentity.GetCurrent().Name;
            }

            foreach (var item in ChangeTracker.Entries<Entity>()
                .Where(x => x.State == EntityState.Added))
            {
                item.Entity.Modified = DateTime.Now;
                item.Entity.Added = item.Entity.Modified;
                item.Entity.ModifiedBy = WindowsIdentity.GetCurrent().Name;
            }

            return base.SaveChanges();  
        }

        private string GetConnectionString()
        {
            var builderAppsettings = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory()) // requires Microsoft.Extensions.Configuration.Json
                 .AddJsonFile($"appsettings.json", optional: true, reloadOnChange: true);

            return builderAppsettings.Build().GetConnectionString("DefaultConnection");
        }
    }
}
