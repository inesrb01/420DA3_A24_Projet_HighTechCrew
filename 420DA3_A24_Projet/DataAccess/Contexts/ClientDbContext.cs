using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.Contexts;
internal class ClientDbContext : DbContext 
{
    public DbSet<client> Clients { get; set; }

    public ClientDbContext(DbContextOptions<ClientDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        // Configuration pour l'entité "client"
        modelBuilder.Entity<client>().ToTable("Clients");
        modelBuilder.Entity<client>().HasKey(c => c.idClient);

        modelBuilder.Entity<client>().Property(c => c.Contactfirstname)
            .IsRequired()
            .HasMaxLength(50);

        modelBuilder.Entity<client>().Property(c => c.Contactlastname)
            .IsRequired()
            .HasMaxLength(50);

        modelBuilder.Entity<client>().Property(c => c.Contactemail)
            .IsRequired()
            .HasMaxLength(100);

        modelBuilder.Entity<client>().Property(c => c.ContactTelephone)
            .HasMaxLength(15);

        modelBuilder.Entity<client>().Property(c => c.address)
            .HasMaxLength(200);

        modelBuilder.Entity<client>().Ignore(c => c.Orders);
    }
}


    


