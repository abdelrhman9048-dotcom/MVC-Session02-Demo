using G_ASP_NET_96_MVC2.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace G_ASP_NET_96_MVC2.Configurations
{
    public class MemberConfigurations : GymUserConfigurations<Member> , IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {

            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()")
            .HasColumnName("JoinDate");

            base.Configure(builder);
        }
    }
}
