using G_ASP_NET_96_MVC2.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace G_ASP_NET_96_MVC2.Configurations
{
    public class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder) {

            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("SessionCapacityConstrain", "Capacity between 1 and 25");

                T.HasCheckConstraint("SessionEndDateAfterStartDate", "EndDate > StartDate");
            });

            builder.HasOne(x => x.Trainer)
            .WithMany(x => x.Sessions)
            .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
