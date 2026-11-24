using G_ASP_NET_96_MVC2.Entites.Enums;

namespace G_ASP_NET_96_MVC2.Entites
{
    public class Member : GymUser
    {
        public string? Photo { get; set; }

        //Relationship
        public ICollection<Membership> MemberSubscriptions { get; set; } = default!;
    }
}
