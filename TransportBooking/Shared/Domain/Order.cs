using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportBooking.Shared.Domain
{
    public class Order : BaseDomainModel
    {
        public string? Name { get; set; }
        public int? RentalPrice { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
