using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.Contexts;
internal class AppDbContexte : DbContext {
    public DbSet<ShippingOrder> ShippingOrders { get; set; }
    public DbSet< Shipment> Shipments { get; set; }
    public DbSet< ShipmentProduct > ShipmentProducts { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer("").UseLazyLoadingProxies();


    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
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


    }


}
