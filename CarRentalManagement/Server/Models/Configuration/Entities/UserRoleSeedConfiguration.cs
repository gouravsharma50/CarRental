using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement.Server.Models.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
               new IdentityUserRole<string>
               {
                   UserId = "67e6b3cf-5a98-4bf5-9abd-551aee9ae452",
                   RoleId = "7736bea9-f68d-4723-9a6b-a3ad2e43758e"
               },
                  new IdentityUserRole<string>
                  {
                      UserId = "67e6b3cf-5a98-4bf5-9abd-551aee9ae453",
                      RoleId = "7736bea9-f68d-4723-9a6b-a3ad2e43768e"
                  }
               );
        }
    }
}

