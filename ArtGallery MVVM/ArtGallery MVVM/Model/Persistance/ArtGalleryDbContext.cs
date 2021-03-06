using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVC.Model.Persistance
{
    public class ArtGalleryDbContext : DbContext
    {
        public static ArtGalleryDbContext instance { get; private set; } = new ArtGalleryDbContext();
        public DbSet<Painting> Paintings { get; set; }
        public DbSet<Sculpture> Sculptures { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Institution> Institutions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=artgallerydb;User ID=postgres;Password=password");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
