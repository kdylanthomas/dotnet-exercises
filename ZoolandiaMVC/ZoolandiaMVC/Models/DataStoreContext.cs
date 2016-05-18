using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ZoolandiaMVC.Models
{
    public class DataStoreContext : DbContext
    {
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Habitat> Habitat { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .ToTable("Animal")
                .HasKey(a => a.IdAnimal);

            modelBuilder.Entity<Habitat>()
                .ToTable("Habitat")
                .HasKey(h => h.IdHabitat);
        }
    }
}