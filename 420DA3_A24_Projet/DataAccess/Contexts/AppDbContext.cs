using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.Contexts;
internal class AppDbContext : DbContext {
    public DbSet<ShippingOrder> ShippingOrders { get; set; }
    public DbSet< Shipment> Shipments { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<ShippingOrderProduct> ShippingOrderProducts { get; set; } // TODO @SOMEONE: completer une classe-pivot ShippingOrderProduct

    public DbSet<Product> Products { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }


    // TODO @TOUT_LE_MONDE: ajouter des DbSet pour les autres classes du domaine

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);

        string connString = ConfigurationManager.ConnectionStrings["ProjectDatabase"]?.ConnectionString
            ?? throw new Exception("No connection string found for key [ProjectDatabase]");

        _ =  optionsBuilder.UseSqlServer(connString).UseLazyLoadingProxies();


    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ShippingOrder>()
            .ToTable(nameof(ShippingOrders))
            .HasKey(x => x.Id);

        modelBuilder.Entity<ShippingOrder>()
            .Property(x => x.Id)
            .HasColumnName(nameof(ShippingOrder.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        modelBuilder.Entity<ShippingOrder>()
            .Property(x => x.Status)
            .HasColumnName(nameof(ShippingOrder.Status))
            .HasColumnOrder(1)
            .HasColumnType("navarchar(24)")
            .IsRequired(true);


        modelBuilder.Entity<ShippingOrder>()
            .Property(x => x.SourceClientId)
            .HasColumnName(nameof(ShippingOrder.SourceClientId))
            .HasColumnOrder(2)
            .HasColumnType("int")
            .IsRequired(true);

        modelBuilder.Entity<ShippingOrder>()
            .Property(x => x.CreatorEmployeeId)
            .HasColumnName(nameof(ShippingOrder.CreatorEmployeeId))
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(true);

        modelBuilder.Entity<ShippingOrder>()
            .Property(x => x.DestinationAddressId)
            .HasColumnName(nameof(ShippingOrder.DestinationAddressId))
            .HasColumnOrder(4)
            .HasColumnType("int")
            .IsRequired(true);

        modelBuilder.Entity<ShippingOrder>()
            .Property(x => x.FulfillEmployeedId)
            .HasColumnName(nameof(ShippingOrder.FulfillEmployeedId))
            .HasColumnOrder(5)
            .HasColumnType("int")
            .IsRequired(false);

        modelBuilder.Entity<ShippingOrder>()
            .Property(x => x.ShippingDate)
            .HasColumnName(nameof(ShippingOrder.ShippingDate))
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        modelBuilder.Entity<ShippingOrder>()
            .Property(x => x.DateCreated)
            .HasColumnName(nameof(ShippingOrder.DateCreated))
            .HasColumnOrder(7)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        modelBuilder.Entity<ShippingOrder>()
            .Property(x => x.DateModified)
            .HasColumnName(nameof(ShippingOrder.DateModified))
            .HasColumnOrder(8)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        modelBuilder.Entity<ShippingOrder>()
            .Property(x => x.DateDeleted)
            .HasColumnName(nameof(ShippingOrder.DateDeleted))
            .HasColumnOrder(9)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        modelBuilder.Entity<ShippingOrder>()
            .Property(so => so.RowVersion)
            .HasColumnName(nameof(ShippingOrder.RowVersion))
            .HasColumnOrder(10)
            .IsRowVersion();




        modelBuilder.Entity<Shipment>()
            .ToTable(nameof(Shipment))
            .HasKey(x => x.Id);

        modelBuilder.Entity<Shipment>()
            .Property(x => x.Id)
            .HasColumnName(nameof(Shipment.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        modelBuilder.Entity<Shipment>()
            .Property(x => x.Status)
            .HasColumnName(nameof(Shipment.Status))
            .HasColumnOrder(1)
            .HasColumnType("nvarchar(24)")
            .IsRequired(true);

        modelBuilder.Entity<Shipment>()
            .Property(x => x.ShippingService)
            .HasColumnName(nameof(Shipment.ShippingService))
            .HasColumnOrder(2)
            .HasColumnType("nvarchar(24)")
            .IsRequired(true);

        modelBuilder.Entity<Shipment>()
            .Property(x => x.ShippingOrderId)
            .HasColumnName(nameof(Shipment.ShippingOrderId))
            .HasColumnOrder(4)
            .HasColumnType("int")
            .IsRequired(true);

        modelBuilder.Entity<Shipment>()
            .Property(x => x.TrackingNumber)
            .HasColumnName(nameof(Shipment.TrackingNumber))
            .HasColumnOrder(3)
            .HasColumnType("string")
            .IsRequired(true);



        modelBuilder.Entity<Shipment>()
            .Property(x => x.DateCreated)
            .HasColumnName(nameof(Shipment.DateCreated))
            .HasColumnOrder(5)
            .HasColumnType("datetime")
            .IsRequired(true);

        modelBuilder.Entity<Shipment>()
            .Property(x => x.DateModified)
            .HasColumnName(nameof(Shipment.DateModified))
            .HasColumnOrder(6)
            .HasColumnType("datetime")
            .IsRequired(false);


        modelBuilder.Entity<Shipment>()
            .Property(x => x.DateDeleted)
            .HasColumnName(nameof(Shipment.DateDeleted))
            .HasColumnOrder(7)
            .HasColumnType("datetime")
            .IsRequired(false);


        //  Supplier
        modelBuilder.Entity<Supplier>()
            .ToTable(nameof(Suppliers))
            .HasKey(x => x.Id);

        modelBuilder.Entity<Supplier>()
            .Property(x => x.Id)
            .HasColumnName(nameof(Supplier.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        modelBuilder.Entity<Supplier>()
            .Property(x => x.SupplierName)
            .HasColumnName(nameof(Supplier.SupplierName))
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Supplier.SupplierNameMaxLength})")
            .IsRequired(true);

        modelBuilder.Entity<Supplier>()
            .Property(x => x.ContactFirstName)
            .HasColumnName(nameof(Supplier.ContactFirstName))
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Supplier.ContactFirstNameMaxLength})")
            .IsRequired(true);

        modelBuilder.Entity<Supplier>()
            .Property(x => x.ContactLastName)
            .HasColumnName(nameof(Supplier.ContactLastName))
            .HasColumnOrder(3)
            .HasColumnType($"nvarchar({Supplier.ContactLastNameMaxLength})")
            .IsRequired(true);

        modelBuilder.Entity<Supplier>()
            .Property(x => x.ContactEmail)
            .HasColumnName(nameof(Supplier.ContactEmail))
            .HasColumnOrder(4)
            .HasColumnType($"nvarchar({Supplier.ContactEmailMaxLength})")
            .IsRequired(true);

        modelBuilder.Entity<Supplier>()
            .Property(x => x.ContactTelephone)
            .HasColumnName(nameof(Supplier.ContactTelephone))
            .HasColumnOrder(5)
            .HasColumnType($"nvarchar({Supplier.ContactTelephoneMaxLength})")
            .IsRequired(true);

        modelBuilder.Entity<Supplier>()
            .Property(x => x.DateCreated)
            .HasColumnName(nameof(Supplier.DateCreated))
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        modelBuilder.Entity<Supplier>()
            .Property(x => x.DateModified)
            .HasColumnName(nameof(Supplier.DateModified))
            .HasColumnOrder(7)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        modelBuilder.Entity<Supplier>()
            .Property(x => x.DateDeleted)
            .HasColumnName(nameof(Supplier.DateDeleted))
            .HasColumnOrder(8)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        modelBuilder.Entity<Supplier>()
            .Property(x => x.RowVersion)
            .HasColumnName(nameof(Supplier.RowVersion))
            .HasColumnOrder(9)
            .IsRowVersion();

        // Product
        modelBuilder.Entity<Product>()
            .ToTable(nameof(Products))
            .HasKey(x => x.Id);

        modelBuilder.Entity<Product>()
            .Property(x => x.Id)
            .HasColumnName(nameof(Product.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        modelBuilder.Entity<Product>()
            .Property(x => x.UpcCode)
            .HasColumnName(nameof(Product.UpcCode))
            .HasColumnOrder(1)
            .HasColumnType("nvarchar(64)")
            .IsRequired(true);

        modelBuilder.Entity<Product>()
            .Property(x => x.ProductName)
            .HasColumnName(nameof(Product.ProductName))
            .HasColumnOrder(2)
            .HasColumnType("nvarchar(128)")
            .IsRequired(true);

        modelBuilder.Entity<Product>()
            .Property(x => x.ProductDescription)
            .HasColumnName(nameof(Product.ProductDescription))
            .HasColumnOrder(3)
            .HasColumnType("nvarchar(max)")
            .IsRequired(false);

        modelBuilder.Entity<Product>()
            .Property(x => x.ImageFileName)
            .HasColumnName(nameof(Product.ImageFileName))
            .HasColumnOrder(4)
            .HasColumnType("nvarchar(256)")
            .IsRequired(false);

        modelBuilder.Entity<Product>()
            .Property(x => x.SupplierCode)
            .HasColumnName(nameof(Product.SupplierCode))
            .HasColumnOrder(5)
            .HasColumnType("nvarchar(64)")
            .IsRequired(true);

        modelBuilder.Entity<Product>()
            .Property(x => x.InStockQty)
            .HasColumnName(nameof(Product.InStockQty))
            .HasColumnOrder(6)
            .HasColumnType("int")
            .IsRequired(true);

        modelBuilder.Entity<Product>()
            .Property(x => x.DesiredQty)
            .HasColumnName(nameof(Product.DesiredQty))
            .HasColumnOrder(7)
            .HasColumnType("int")
            .IsRequired(true);

        modelBuilder.Entity<Product>()
            .Property(x => x.WeightInKg)
            .HasColumnName(nameof(Product.WeightInKg))
            .HasColumnOrder(8)
            .HasColumnType("float")
            .IsRequired(true);

        modelBuilder.Entity<Product>()
            .Property(x => x.DateCreated)
            .HasColumnName(nameof(Product.DateCreated))
            .HasColumnOrder(9)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        modelBuilder.Entity<Product>()
            .Property(x => x.DateModified)
            .HasColumnName(nameof(Product.DateModified))
            .HasColumnOrder(10)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        modelBuilder.Entity<Product>()
            .Property(x => x.DateDeleted)
            .HasColumnName(nameof(Product.DateDeleted))
            .HasColumnOrder(11)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        modelBuilder.Entity<Product>()
            .Property(x => x.RowVersion)
            .HasColumnName(nameof(Product.RowVersion))
            .HasColumnOrder(12)
            .IsRowVersion();

        modelBuilder.Entity<Product>()
            .Property(x => x.OwnerClientId)
            .HasColumnName(nameof(Product.OwnerClientId))
            .HasColumnOrder(13)
            .HasColumnType("int")
            .IsRequired(true);

        modelBuilder.Entity<Product>()
            .Property(x => x.SupplierId)
            .HasColumnName(nameof(Product.SupplierId))
            .HasColumnOrder(14)
            .HasColumnType("int")
            .IsRequired(true);

        // Relations
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Supplier)
            .WithMany(s => s.Products)
            .HasForeignKey(p => p.SupplierId)
            .OnDelete(DeleteBehavior.Restrict);
        

        











        // TODO @TOUT_LE_MONDE: configurez vous entités ici

        // classe client 
    public DbSet<Client> Clients { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);

        string connString = ConfigurationManager.ConnectionStrings["ProjectDatabase"]?.ConnectionString
            ?? throw new Exception("No connection string found for key [ProjectDatabase]");

        optionsBuilder.UseSqlServer(connString).UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        // Configuration pour Client
        modelBuilder.Entity<Client>()
            .ToTable(nameof(Clients))
            .HasKey(x => x.Id);

        modelBuilder.Entity<Client>()
            .Property(x => x.Id)
            .HasColumnName(nameof(Client.Id))
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        modelBuilder.Entity<Client>()
            .Property(x => x.ClientName)
            .HasColumnName(nameof(Client.ClientName))
            .HasColumnType("nvarchar(128)")
            .IsRequired(true);

        modelBuilder.Entity<Client>()
            .Property(x => x.DateCreated)
            .HasColumnName(nameof(Client.DateCreated))
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        modelBuilder.Entity<Client>()
            .Property(x => x.DateModified)
            .HasColumnName(nameof(Client.DateModified))
            .HasColumnType("datetime2")
            .HasPrecision(7);

        modelBuilder.Entity<Client>()
            .Property(x => x.DateDeleted)
            .HasColumnName(nameof(Client.DateDeleted))
            .HasColumnType("datetime2")
            .HasPrecision(7);

        modelBuilder.Entity<Client>()
            .Property(x => x.RowVersion)
            .HasColumnName(nameof(Client.RowVersion))
            .IsRowVersion();

        // Configuration pour Warehouse
        modelBuilder.Entity<Warehouse>()
            .ToTable(nameof(Warehouses))
            .HasKey(x => x.Id);

        modelBuilder.Entity<Warehouse>()
            .Property(x => x.Id)
            .HasColumnName(nameof(Warehouse.Id))
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        modelBuilder.Entity<Warehouse>()
            .Property(x => x.WarehouseName)
            .HasColumnName(nameof(Warehouse.WarehouseName))
            .HasColumnType("nvarchar(128)")
            .IsRequired(true);

        modelBuilder.Entity<Warehouse>()
            .Property(x => x.AddressId)
            .HasColumnName(nameof(Warehouse.AddressId))
            .HasColumnType("int")
            .IsRequired(true);

        modelBuilder.Entity<Warehouse>()
            .Property(x => x.DateCreated)
            .HasColumnName(nameof(Warehouse.DateCreated))
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        modelBuilder.Entity<Warehouse>()
            .Property(x => x.DateModified)
            .HasColumnName(nameof(Warehouse.DateModified))
            .HasColumnType("datetime2")
            .HasPrecision(7);

        modelBuilder.Entity<Warehouse>()
            .Property(x => x.DateDeleted)
            .HasColumnName(nameof(Warehouse.DateDeleted))
            .HasColumnType("datetime2")
            .HasPrecision(7);

        modelBuilder.Entity<Warehouse>()
            .Property(x => x.RowVersion)
            .HasColumnName(nameof(Warehouse.RowVersion))
            .IsRowVersion();



        // TODO @TOUT_LE_MONDE: configurez les relations entre les entités ici

        modelBuilder.Entity<Warehouse>()
               .HasMany(w => w.Clients)
               .WithOne(c => c.Warehouse)
               .HasForeignKey(c => c.WarehouseId)
               .OnDelete(DeleteBehavior.Restrict);









        // TODO @TOUT_LE_MONDE: ajouter l'insertion de données initiales ici
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

    }
}

        



