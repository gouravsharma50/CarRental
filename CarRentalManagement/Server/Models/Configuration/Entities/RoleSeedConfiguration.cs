using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CarRentalManagement.Server.Models.Configuration.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
               new IdentityRole
               {
                   Id = "7736bea9-f68d-4723-9a6b-a3ad2e43768e",
                   Name = "User",
                   NormalizedName = "USER",

               },
                new IdentityRole
                {
                    Id = "7736bea9-f68d-4723-9a6b-a3ad2e43758e",
                    Name = "Adminstrator",
                    NormalizedName = "ADMINSTRATOR",
                }
               );
        }
    }
}
