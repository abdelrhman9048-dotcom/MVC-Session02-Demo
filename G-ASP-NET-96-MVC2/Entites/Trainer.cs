using G_ASP_NET_96_MVC2.Entites.Enums;

namespace G_ASP_NET_96_MVC2.Entites
{
    public class Trainer : GymUser
    {
        public DateTime HireDate { get; set; }
        public Specialties Specialties { get; set; }

        //Relationship
        public ICollection<Session> Sessions { get; set; } = default!;
    }
}
