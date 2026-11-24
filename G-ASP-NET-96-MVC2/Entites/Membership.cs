using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace G_ASP_NET_96_MVC2.Entites
{
    public class Membership : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; } = default!;

        public int PlanId { get; set; }
        public Plan Plan { get; set; } = default!;

        [NotMapped]
        public string Status => StartDate > DateTime.Now ? "UpComing" :
                                EndDate > DateTime.Now ? "Active" :
                                "Expired";
    }
}
