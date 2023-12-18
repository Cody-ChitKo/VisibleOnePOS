using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisibleOnePOS.Models.Member
{
    public class MemberModel
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string TotalPoints { get; set; }
        public decimal RedeemedPoints { get; set; }
        public string Status { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
