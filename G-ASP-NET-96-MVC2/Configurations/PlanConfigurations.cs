using G_ASP_NET_96_MVC2.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace G_ASP_NET_96_MVC2.Configurations
{
    public class PlanConfigurations : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {

            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");

            builder.ToTable(t =>
            t.HasCheckConstraint(
             "PlanDurationCheck",
            "DurationDays between 1 and 365"));
        }
    }
}
