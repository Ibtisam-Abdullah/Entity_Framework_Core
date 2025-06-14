using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public class ShippingAddress
    {
        [Key]
        public int AddressID { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [Required, MaxLength(255)]
        public string StreetAddress { get; set; } = null!;

        [Required, MaxLength(100)]
        public string City { get; set; } = null!;

        [Required, MaxLength(100)]
        public string State { get; set; } = null!;

        [Required, MaxLength(100)]
        public string Country { get; set; } = null!;

        [Required, MaxLength(20)]
        public string PostalCode { get; set; } = null!;

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; } = null!;
    }


}
