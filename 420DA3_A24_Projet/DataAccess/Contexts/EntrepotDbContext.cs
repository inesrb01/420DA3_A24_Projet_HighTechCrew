using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.Contexts;
internal class EntrepotDbContext : DbContext 
{
    public DbSet<entrepots> Entrepots { get; set; }

    public EntrepotDbContext(DbContextOptions<EntrepotDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {

        modelBuilder.Entity<entrepots>().ToTable("Entrepots");
        modelBuilder.Entity<entrepots>().HasKey(e => e.entrepotID);
        modelBuilder.Entity<entrepots>().Property(e => e.Nom)
            .IsRequired()
            .HasMaxLength(100);
        modelBuilder.Entity<entrepots>().Property(e => e.entrepotAddresse)
            .IsRequired()
            .HasMaxLength(200);

        modelBuilder.Entity<entrepots>().Property(e => e.entrepotlieu)
            .HasMaxLength(100);

        modelBuilder.Entity<entrepots>().Ignore(e => e.Produits);
    }
}



