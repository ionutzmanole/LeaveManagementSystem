using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "5a5f0781-baae-430c-bb39-bccf190a2c8c",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                },
                new IdentityRole
                {
                    Id = "8fe0b8af-b76d-45f9-94b9-c3b7d43b02e9",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR"
                },
                new IdentityRole
                {
                    Id = "c0e43562-d3b3-450b-bf3e-62fdd5b52fbe",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                });

            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>()
                .HasData(new ApplicationUser
                {
                    Id = "04ac873d-99e4-4f23-86d7-f2bbf18d18ae",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    PasswordHash = hasher.HashPassword(null, "P@rola1!"),
                    EmailConfirmed = true,
                    FirstName = "Default",
                    LastName = "Default",
                    DateOfBirth = new DateOnly(1978, 10, 27)

                });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "c0e43562-d3b3-450b-bf3e-62fdd5b52fbe",
                    UserId = "04ac873d-99e4-4f23-86d7-f2bbf18d18ae"
                }
                );
        }

        

        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
}
