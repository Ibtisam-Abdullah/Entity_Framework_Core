using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } 

        [Required, MaxLength(100), EmailAddress]
        public string Email { get; set; }

        [MaxLength(20)]
        public string? Phone { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<ShippingAddress> ShippingAddresses { get; set; } = new List<ShippingAddress>();
        public ICollection<PaymentInformation> PaymentInformation { get; set; } = new List<PaymentInformation>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }


}
