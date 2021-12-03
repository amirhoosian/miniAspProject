using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace myAspMiniProject.Models
{
    public partial class miniApiContext : DbContext
    {
        public miniApiContext()
        {
        }

        public miniApiContext(DbContextOptions<miniApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Publishersauthor> Publishersauthors { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=miniApi;Username=postgres;Password=229114");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>(entity =>
            {
                entity.ToTable("articles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Imagename)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("imagename");

                entity.Property(e => e.Publisherid).HasColumnName("publisherid");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("text");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.Publisherid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("articles_publisherid_fkey");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.ToTable("publishers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("logo");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Publishersauthor>(entity =>
            {
                entity.ToTable("publishersauthors");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Authorid).HasColumnName("authorid");

                entity.Property(e => e.Publisherid).HasColumnName("publisherid");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Publishersauthors)
                    .HasForeignKey(d => d.Authorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("publishersauthors_authorid_fkey");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Publishersauthors)
                    .HasForeignKey(d => d.Publisherid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("publishersauthors_publisherid_fkey");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Email, "users_email_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("fullname");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
