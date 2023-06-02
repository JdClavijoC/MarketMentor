using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarketMentor.Configuration.Entities
{
    internal class UserRolSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "67e26e4c-409b-4abc-82cd-d24d0255626e",
                    UserId = "02f63707-30f8-47f0-af90-e96561934ff1"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "67e26e4c-459bc-4abc-81dd-d24d0255626",
                     UserId = "67e26e4c-409b-4abc-81dd-d24d0255626e"
                 });
        }     
    }
}