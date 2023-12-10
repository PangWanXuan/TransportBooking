using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportBooking.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentCredential { get; set; }
        
    }
}
