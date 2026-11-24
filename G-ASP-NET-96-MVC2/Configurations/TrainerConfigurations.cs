using G_ASP_NET_96_MVC2.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace G_ASP_NET_96_MVC2.Configurations
{
    public class TrainerConfigurations : GymUserConfigurations<Trainer> , IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {

            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");

            base.Configure(builder);
        }
    }
}
