namespace MilShop.WebUI
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Colors> Colors { get; set; }
        public virtual DbSet<Hats> Hats { get; set; }
        public virtual DbSet<HatsCategory> HatsCategory { get; set; }
        public virtual DbSet<Outerwear> Outerwear { get; set; }
        public virtual DbSet<OuterwearCategory> OuterwearCategory { get; set; }
        public virtual DbSet<Pants> Pants { get; set; }
        public virtual DbSet<PantsCategory> PantsCategory { get; set; }
        public virtual DbSet<Quantity> Quantity { get; set; }
        public virtual DbSet<Shoes> Shoes { get; set; }
        public virtual DbSet<ShoesCategory> ShoesCategory { get; set; }
        public virtual DbSet<Sizes> Sizes { get; set; }
        public virtual DbSet<TacticalEquipment> TacticalEquipment { get; set; }
        public virtual DbSet<TacticalEquipmentCategory> TacticalEquipmentCategory { get; set; }
        public virtual DbSet<Uniforms> Uniforms { get; set; }
        public virtual DbSet<UniformsCategory> UniformsCategory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Colors>()
                .HasMany(e => e.Outerwear)
                .WithOptional(e => e.Colors)
                .HasForeignKey(e => e.Color);

            modelBuilder.Entity<Colors>()
                .HasMany(e => e.Pants)
                .WithOptional(e => e.Colors)
                .HasForeignKey(e => e.Color);

            modelBuilder.Entity<Colors>()
                .HasMany(e => e.Shoes)
                .WithOptional(e => e.Colors)
                .HasForeignKey(e => e.Color);

            modelBuilder.Entity<Colors>()
                .HasMany(e => e.TacticalEquipment)
                .WithOptional(e => e.Colors)
                .HasForeignKey(e => e.Color);

            modelBuilder.Entity<Colors>()
                .HasMany(e => e.Uniforms)
                .WithOptional(e => e.Colors)
                .HasForeignKey(e => e.Color);

            modelBuilder.Entity<HatsCategory>()
                .HasMany(e => e.Hats)
                .WithRequired(e => e.HatsCategory)
                .HasForeignKey(e => e.hat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OuterwearCategory>()
                .HasMany(e => e.Outerwear)
                .WithRequired(e => e.OuterwearCategory)
                .HasForeignKey(e => e.outrwr)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PantsCategory>()
                .HasMany(e => e.Pants)
                .WithRequired(e => e.PantsCategory)
                .HasForeignKey(e => e.pants1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShoesCategory>()
                .HasMany(e => e.Shoes)
                .WithRequired(e => e.ShoesCategory)
                .HasForeignKey(e => e.shoes1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sizes>()
                .HasMany(e => e.Hats)
                .WithOptional(e => e.Sizes)
                .HasForeignKey(e => e.Size);

            modelBuilder.Entity<Sizes>()
                .HasMany(e => e.Outerwear)
                .WithOptional(e => e.Sizes)
                .HasForeignKey(e => e.Size);

            modelBuilder.Entity<Sizes>()
                .HasMany(e => e.Pants)
                .WithOptional(e => e.Sizes)
                .HasForeignKey(e => e.Size);

            modelBuilder.Entity<Sizes>()
                .HasMany(e => e.Shoes)
                .WithOptional(e => e.Sizes)
                .HasForeignKey(e => e.Size);

            modelBuilder.Entity<Sizes>()
                .HasMany(e => e.TacticalEquipment)
                .WithOptional(e => e.Sizes)
                .HasForeignKey(e => e.Size);

            modelBuilder.Entity<Sizes>()
                .HasMany(e => e.Uniforms)
                .WithOptional(e => e.Sizes)
                .HasForeignKey(e => e.Size);

            modelBuilder.Entity<TacticalEquipmentCategory>()
                .HasMany(e => e.TacticalEquipment)
                .WithRequired(e => e.TacticalEquipmentCategory)
                .HasForeignKey(e => e.taceq)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UniformsCategory>()
                .HasMany(e => e.Uniforms)
                .WithRequired(e => e.UniformsCategory)
                .HasForeignKey(e => e.uniform)
                .WillCascadeOnDelete(false);
        }
    }
}
