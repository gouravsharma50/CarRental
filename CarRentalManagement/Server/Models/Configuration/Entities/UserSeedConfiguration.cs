using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CarRentalManagement.Server.Models.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
               new ApplicationUser
               {
                   Id = "67e6b3cf-5a98-4bf5-9abd-551aee9ae452",
                   Email = "admin@localhost.com",
                   NormalizedEmail = "ADMIN@LOCALHOST.COM",
                   FirstName = "System",
                   LastName = "Admin",
                   UserName = "admin@localhost.com",
                   NormalizedUserName = "ADMIN@LOCALHOST.COM",
                   PasswordHash = hasher.HashPassword(null, "P@ssword1")
               },
                  new ApplicationUser
                  {
                      Id = "67e6b3cf-5a98-4bf5-9abd-551aee9ae453",
                      Email = "user@localhost.com",
                      NormalizedEmail = "USER@LOCALHOST.COM",
                      FirstName = "System",
                      LastName = "User",
                      UserName = "user@localhost.com",
                      NormalizedUserName = "USER@LOCALHOST.COM",
                      PasswordHash = hasher.HashPassword(null, "P@ssword1")
                  }
               );
        }
    }
}
