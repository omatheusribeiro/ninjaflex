using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ninjaflex.Domain.Entities;

namespace ninjaflex.Data.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.UserCreation);

            builder.Property(p => p.UserAlteration);

            builder.Property(p => p.UserExclusion);

            builder.Property(p => p.DateCreation).IsRequired();

            builder.Property(p => p.DateAlteration);

            builder.Property(p => p.DateExclusion);

            builder.Property(p => p.FirstName).HasMaxLength(100).IsRequired();

            builder.Property(p => p.LastName).HasMaxLength(100).IsRequired();

            builder.Property(p => p.Email).HasMaxLength(100).IsRequired();

            builder.Property(p => p.Password).HasMaxLength(100).IsRequired();

            builder.Property(x => x.BarCode).HasMaxLength(10);

            builder.Property(p => p.UserTypeId).IsRequired();

            builder.Property(p => p.Status).IsRequired();

            builder.HasData(
                new User
                {
                    Id = 1,
                    UserCreation = null,
                    UserAlteration = null,
                    UserExclusion = null,
                    DateCreation = DateTime.Now,
                    DateAlteration = null,
                    DateExclusion = null,
                    FirstName = "Admin",
                    LastName = "Ninjaflex",
                    Email = "ninjaflex@admin.com",
                    Password = "",
                    BarCode = null,
                    UserTypeId = 1,
                    Status = true,
                }); ;
        }
    }
}
