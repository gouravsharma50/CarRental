using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Shared.Domain;

namespace CarRentalManagement.Server.Models.Configuration.Entities
{
    public class MakeSeedConfigurationClass : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
               new Make
               {
                   Id = 1,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdate = DateTime.Now,
                   Name = "BMW",
                   UpdatedBy = "System"
               },
                new Make
                {
                    Id = 2,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    Name = "Toyota",
                    UpdatedBy = "System"
                }
               );
        }
    }
}