using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreCleanArch.Domain
{
    public class Rental
    {
        public int RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime RentalExpire { get; set; }
        public decimal TotalCost { get; set; }

        // Linking One to Many
        public ICollection<Member> Members { get; set; }
    }
}
