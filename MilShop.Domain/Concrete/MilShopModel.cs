using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using MilShop.Domain.Entities;

public partial class MilShopModel : DbContext
{
    public MilShopModel()
        : base("name=MilShopDB")
    {
    }

    public virtual DbSet<Color> Colors { get; set; }
    public virtual DbSet<Price> Prices { get; set; }
    public virtual DbSet<Size> Sizes { get; set; }
    public virtual DbSet<Sniker> Snikers { get; set; }
    public virtual DbSet<WinterJacket> WinterJackets { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Color>()
            .HasMany(e => e.Snikers)
            .WithOptional(e => e.Color1)
            .HasForeignKey(e => e.Color);

        modelBuilder.Entity<Price>()
            .HasMany(e => e.Snikers)
            .WithOptional(e => e.Price1)
            .HasForeignKey(e => e.Price);

        modelBuilder.Entity<Size>()
            .HasMany(e => e.Snikers)
            .WithOptional(e => e.Size1)
            .HasForeignKey(e => e.Size);

        modelBuilder.Entity<Color>()
           .HasMany(e => e.WinterJackets)
           .WithOptional(e => e.Color1)
           .HasForeignKey(e => e.Color);

        modelBuilder.Entity<Price>()
            .HasMany(e => e.WinterJackets)
            .WithOptional(e => e.Price1)
            .HasForeignKey(e => e.Price);

        modelBuilder.Entity<Size>()
            .HasMany(e => e.WinterJackets)
            .WithOptional(e => e.Size1)
            .HasForeignKey(e => e.Size);
    }
}
