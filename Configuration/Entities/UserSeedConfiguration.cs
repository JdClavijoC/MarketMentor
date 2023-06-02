using MarketMentor.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarketMentor.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "02f63707-30f8-47f0-af90-e96561934ff1",
                    Email = "jdclavijoc@ufpso.edu.co",
                    NormalizedEmail = "JDCLAVIJOC@UFPSO.EDU.CO",
                    NormalizedUserName = "JDCLAVIJOC@UFPSO.EDU.CO",
                    UserName = "jdclavijoc@ufpso.edu.co",
                    Firstname = "Jesus David",
                    Lastname = "Clavijo Cardenas",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new Employee
                {
                    Id = "67e26e4c-409b-4abc-81dd-d24d0255626e",
                    Email = "jaclagar1234@gmail.com",
                    NormalizedEmail = "JACLAGAR1234@GMAIL.COM",
                    NormalizedUserName = "JACLAGAR1234@GMAIL.COM",
                    UserName = "jaclagar1234@gmail.com",
                    Firstname = "Jesus",
                    Lastname = "David",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")

                });
        }
    }
}