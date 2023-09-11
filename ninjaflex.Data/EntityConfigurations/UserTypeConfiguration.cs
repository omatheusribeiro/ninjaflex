using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ninjaflex.Domain.Entities;

namespace ninjaflex.Data.EntityConfigurations
{
    public class UserTypeConfiguration : IEntityTypeConfiguration<UserType>
    {
        public void Configure(EntityTypeBuilder<UserType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.UserCreation);

            builder.Property(p => p.UserAlteration);

            builder.Property(p => p.UserExclusion);

            builder.Property(p => p.DateCreation).IsRequired();

            builder.Property(p => p.DateAlteration);

            builder.Property(p => p.DateExclusion);

            builder.Property(p => p.Description).HasMaxLength(100).IsRequired();

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
                    Status = true,
                }); ;
        }
    }
}
