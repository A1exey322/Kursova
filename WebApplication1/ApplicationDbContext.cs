using WebApplication1.Entity;
using WebApplication1.Data.Enum;
using WebApplication1.Data;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(builder =>
            {
                builder.ToTable("Users").HasKey(x => x.Id); 

                builder.HasData(new User
                {
                    Id = 1,
                    Name = "Alexey",
                    Password = HashPasswordHelper.HashPassword("qwerty"),
                    Role = Role.Admin,
                    Liked = ""
                }); 

                builder.Property(x => x.Id).ValueGeneratedOnAdd();

                builder.Property(x => x.Password).IsRequired();
                builder.Property(x => x.Name).HasMaxLength(100).IsRequired();

                builder.Property(x => x.Liked);

                builder.HasOne(x => x.Profile)
                    .WithOne(x => x.User)
                    .HasPrincipalKey<User>(x => x.Id)
                    .OnDelete(DeleteBehavior.ClientCascade);
            });

            modelBuilder.Entity<Profile>(builder =>
            {
                builder.ToTable("Profiles").HasKey(x => x.Id);

                builder.Property(x => x.Id).ValueGeneratedOnAdd();

                builder.Property(x => x.Age);
                builder.Property(x => x.Address).HasMaxLength(250);
                builder.Property(x => x.UserId);
            });
        }
    }
}

