using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using News.Domain.Entities;

namespace News.Infracstructure.Data
{
    public partial class NewsDbContext : DbContext
    {
        public NewsDbContext()
        {
        }
        public NewsDbContext(DbContextOptions<NewsDbContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json", true, true);
                IConfigurationRoot configuration = builder.Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlData"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entiry =>
            {
                entiry.HasKey(r => r.Id);
                entiry.Property(r => r.RoleName);
            });

            modelBuilder.Entity<User>(entiry =>
            {
                entiry.HasKey(u => u.Id);
                entiry.Property(u => u.UserName);
                entiry.Property(u => u.PasswordHash);
                entiry.Property(u => u.Email);

                entiry.HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.CategoryName);
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(a => a.Id);
                entity.Property(a => a.Title);
                entity.Property(a => a.Content);
                entity.Property(a => a.PubliccationDate);
                entity.Property(a => a.ImageUrl);
                entity.Property(a => a.Priority);

                entity.HasOne(a => a.User)
                .WithMany(u => u.Articles)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(c => c.Category)
                .WithMany(a => a.Articles)
                .HasForeignKey(a => a.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);
            });
        }
    }
}
