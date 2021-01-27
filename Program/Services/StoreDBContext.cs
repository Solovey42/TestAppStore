using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Store
{
    public partial class StoreDBContext : DbContext
    {
        public StoreDBContext()
        {
        }

        public StoreDBContext(DbContextOptions<StoreDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ViewOrder> ViewOrders { get; set; }
        public virtual DbSet<ViewProduct> ViewProducts { get; set; }
        public virtual DbSet<ViewClient> ViewClients { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5432;Database=StoreDB;Username=postgres;Password=2363");
            }
        }
     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("clients");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<ViewClient>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Number).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Phone).HasColumnType("phone");


            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Productid).HasColumnName("productid");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Clientid)
                    .HasConstraintName("orders_clientid_fkey");
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Productid)
                    .HasConstraintName("orders_productid_fkey");
            });

            modelBuilder.Entity<ViewOrder>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Number).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Date).HasColumnType("date");

               
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Info)
                    .HasMaxLength(100)
                    .HasColumnName("info");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ViewProduct>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Number).HasColumnName("id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Info).HasColumnType("info");


            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
