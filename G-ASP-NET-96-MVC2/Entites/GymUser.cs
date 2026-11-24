using G_ASP_NET_96_MVC2.Entites.Enums;

namespace G_ASP_NET_96_MVC2.Entites
{
    public abstract class GymUser : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;

        public DateOnly DateOfBirth { get; set; }

        public Gender Gender { get; set; }
        public Address Address { get; set; } = default!;
    }
}
