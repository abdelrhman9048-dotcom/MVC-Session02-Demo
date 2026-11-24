using G_ASP_NET_96_MVC2.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace G_ASP_NET_96_MVC2.Configurations
{
    public class GymUserConfigurations<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {

            builder.Property(x => x.Name)
            .HasColumnType("varchar")
            .HasMaxLength(50);

            builder.Property(x => x.Phone)
            .HasColumnType("varchar")
            .HasMaxLength(11);

            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.Phone).IsUnique();

            builder.ToTable(T =>
            { 
            T.HasCheckConstraint("GymUser_EmailCheck", "Email LIKE '_%@_% ._ %'");
                T.HasCheckConstraint("GymUser_PhoneCheck", "LEN(Phone) = 11 AND (Phone LIKE '010%' OR Phone LIKE '011%' OR Phone LIKE '012%' OR Phone LIKE '015%')");
            });

            builder.ComplexProperty(x => x.Address); //Composite attribute
        }
    }
}
