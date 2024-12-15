using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Configuration;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace _420DA3_A24_Projet.DataAccess.Contexts;

public class AppDbContext : DbContext {
    // DbSet Properties
    public DbSet<User> User { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<ShippingOrder> ShippingOrders { get; set; }
    public DbSet<Shipment> Shipments { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ProjectOrder;Persist Security Info=True;Pooling=False;Multiple Active Result Sets=False;Encrypt=True;Trust Server Certificate=True;Command Timeout=0")
                      .UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        // Example Configuration: ShippingOrder
        modelBuilder.Entity<ShippingOrder>(entity =>
        {
            entity.ToTable(nameof(ShippingOrders));
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                  .HasColumnType("int")
                  .UseIdentityColumn(1, 1);

            entity.Property(e => e.Status)
                  .HasColumnType("nvarchar(24)")
                  .IsRequired();

            entity.Property(e => e.DateCreated)
                  .HasColumnType("datetime2")
                  .HasDefaultValueSql("GETDATE()")
                  .IsRequired();
        });

        // Example Configuration: Supplier
        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.ToTable(nameof(Suppliers));
            entity.HasKey(e => e.Id);

            entity.Property(e => e.SupplierName)
                  .HasColumnType($"nvarchar(128)")
                  .IsRequired();

            entity.Property(e => e.ContactFirstName)
                  .HasColumnType($"nvarchar(64)")
                  .IsRequired();

            entity.Property(e => e.ContactLastName)
                  .HasColumnType($"nvarchar(64)")
                  .IsRequired();

            entity.Property(e => e.ContactEmail)
                  .HasColumnType($"nvarchar(128)")
                  .IsRequired();

            entity.Property(e => e.ContactTelephone)
                  .HasColumnType($"nvarchar(24)")
                  .IsRequired();

            entity.Property(e => e.DateCreated)
                  .HasColumnType("datetime2")
                  .HasDefaultValueSql("GETDATE()")
                  .IsRequired();
        });

        // Initial Data
        modelBuilder.Entity<Warehouse>().HasData(new Warehouse {
            Id = 1,
            WarehouseName = "Main Warehouse",
            AddressId = 1,
            DateCreated = DateTime.Now
        });

        modelBuilder.Entity<Client>().HasData(new Client {
            Id = 1,
            ClientName = "Default Client",
            WarehouseId = 1,
            DateCreated = DateTime.Now
        });

        modelBuilder.Entity<Address>().HasData(new Address {
            Id = 1,
            Addressee = "122 Rue Sainte Catherine",
            CivicNumber = "122",
            Street = "Rue Saint Catherine",
            City = "Montreal",
            State = "Quebec",
            Country = "Canada",
            PostalCode = "H2B0S7",
            DateCreated = DateTime.Now,
            RowVersion = Array.Empty<byte>() 
        });

    }
}