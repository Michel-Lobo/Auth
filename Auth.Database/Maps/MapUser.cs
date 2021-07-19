
using Auth.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Auth.Database.Maps
{
    public class MapUser : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
              .HasMaxLength(150)
              .IsRequired();

            builder.Property(x => x.Password)
              .HasMaxLength(250)
              .IsRequired();

         

            builder.Property(x => x.Email)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasOne<Role>(p => p.Role).WithMany(p => p.Users).HasForeignKey(p => p.RoleId);
            builder.HasOne<Application>(p => p.Application).WithMany(p => p.Users).HasForeignKey(p => p.ApplicationId);

            //builder.Property(x => x.CodeConfirm)
            //    .HasMaxLength(50);

            //builder.Property(x => x.CodeReset)
            //    .HasMaxLength(50);

            //builder.Property(x => x.DateExpireConfirm)
            //   .IsRequired(false);

            //builder.Property(x => x.DateExpireConfirm)
            //  .IsRequired(false);

            //builder.Property(x => x.Confirmed)
            // .IsRequired(false)
            // .HasDefaultValue(false);
            //builder.Property(p => p.Phone).IsRequired(true).HasMaxLength(11);
        }
    }
}
