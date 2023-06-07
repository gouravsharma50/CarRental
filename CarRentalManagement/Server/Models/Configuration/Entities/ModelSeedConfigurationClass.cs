using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Models.Configuration.Entities
{
    public class ModelSeedConfigurationClass : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
               new Model
               {
                   Id = 1,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdate = DateTime.Now,
                   Name = "3 series",
                   UpdatedBy = "System",
                  
               },
                new Model
                {
                    Id = 2,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    Name = "Vitz",
                    UpdatedBy = "System"
                },
                 new Model
                 {
                     Id = 3,
                     CreatedBy = "System",
                     DateCreated = DateTime.Now,
                     DateUpdate = DateTime.Now,
                     Name = "Prius",
                     UpdatedBy = "System"
                 },
                   new Model
                   {
                       Id = 4,
                       CreatedBy = "System",
                       DateCreated = DateTime.Now,
                       DateUpdate = DateTime.Now,
                       Name = "X5",
                       UpdatedBy = "System"
                   }
               );
        }
    }
}
    