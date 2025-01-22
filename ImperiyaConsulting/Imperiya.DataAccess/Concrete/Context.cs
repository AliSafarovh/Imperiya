using Imperiya.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imperiya.DataAccess.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DELL;Database=ImperiyaDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Animated> Animateds { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Pics> Picses { get; set; }
        public DbSet<Publicity> Publicities { get; set; }
        public DbSet<ServiceCard> ServiceCards { get; set; }
    }
}
