using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public class PaymentInformation
    {
        [Key]
        public int PaymentID { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [Required, MaxLength(50)]
        public string PaymentMethod { get; set; } 

        [Required, MaxLength(20)]
        public string CardNumber { get; set; } 

        [Required, MaxLength(7)]
        public string ExpirationDate { get; set; }

        [Required, MaxLength(4)]
        public string CVV { get; set; } 

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; } 
    }


}
