using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Diagnostics.Metrics;

namespace _420DA3_A24_Projet.DataAccess.Contexts;
public class AppDbContexte : DbContext {
    public DbSet<ShippingOrder> ShippingOrders { get; set; }
    public DbSet< Shipment> Shipments { get; set; }
    public DbSet<User>  Users { get; set; }
    public DbSet<Role>  Roles { get; set; }
    public DbSet<Warehouse> Warehouse { get; set; }

    //public DbSet<ShipmentProduct> ShipmentProducts { get; set; } // TODO @SOMEONE: completer une classe-pivot ShippingOrderProduct

    // TODO @TOUT_LE_MONDE: ajouter des DbSet pour les autres classes du domaine

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);

        ConnectionStringSettings connexionString = ConfigurationManager.ConnectionStrings["ProjectDatabase"];
        _ = optionsBuilder.UseSqlServer(connexionString.ConnectionString).UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().Property(o => o.RowVersion).IsRowVersion();
        modelBuilder.Entity<Role>().Property(o => o.RowVersion).IsRowVersion();
        modelBuilder.Entity<User>().HasQueryFilter(o => o.DateDeleted == null);



        modelBuilder.Entity<ShippingOrder>().HasOne(o => o.CreatorEmplyee).WithMany(o => o.CreatedShipOrders).HasForeignKey(o => o.CreatorEmployeeId);


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
            .HasColumnName(nameof (Shipment.Id))
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        modelBuilder.Entity<ShippingOrder>()
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




        // TODO @TOUT_LE_MONDE: configurez vous entités ici








        // TODO @TOUT_LE_MONDE: configurez les relations entre les entités ici








        // TODO @TOUT_LE_MONDE: ajouter l'insertion de données initiales ici


    }

}
