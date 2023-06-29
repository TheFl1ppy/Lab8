using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.SQL
{
    public partial class PracticaContext : DbContext
    {
        public PracticaContext()
        {
        }

        public PracticaContext(DbContextOptions<PracticaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart> Carts { get; set; } = null!;
        public virtual DbSet<CategoriseProduct> CategoriseProducts { get; set; } = null!;
        public virtual DbSet<Filter> Filters { get; set; } = null!;
        public virtual DbSet<OrderUser> OrderUsers { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<TypeDelivery> TypeDeliveries { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-SG7FFM7;Database=Practica;User Id=sa;Password=12345;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasKey(e => new { e.IdOrder, e.IdProduct });

                entity.ToTable("Cart");

                entity.HasOne(d => d.IdOrderNavigation)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.IdOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cart_OrderUser");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cart_Product");
            });

            modelBuilder.Entity<CategoriseProduct>(entity =>
            {
                entity.ToTable("CategoriseProduct");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Filter>(entity =>
            {
                entity.ToTable("Filter");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CategoriseNavigation)
                    .WithMany(p => p.Filters)
                    .HasForeignKey(d => d.Categorise)
                    .HasConstraintName("FK_Filter_CategoriseProduct");
            });

            modelBuilder.Entity<OrderUser>(entity =>
            {
                entity.ToTable("OrderUser");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.HasOne(d => d.IdUsersNavigation)
                    .WithMany(p => p.OrderUsers)
                    .HasForeignKey(d => d.IdUsers)
                    .HasConstraintName("FK_OrderUser_Users");

                entity.HasOne(d => d.TypeDeliveryNavigation)
                    .WithMany(p => p.OrderUsers)
                    .HasForeignKey(d => d.TypeDelivery)
                    .HasConstraintName("FK_OrderUser_TypeDelivery");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CategoriesNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Categories)
                    .HasConstraintName("FK_Product_CategoriseProduct");
            });

            modelBuilder.Entity<TypeDelivery>(entity =>
            {
                entity.ToTable("TypeDelivery");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Card)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
