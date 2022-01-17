using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Skylakias.Models
{
    public class Order
    {

        [Key, Column(Order = 0)]
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }

        [Key, Column(Order = 1)]
        public int ServiceId { get; set; }

        [Display(Name = "Total Price")]
        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }
        public virtual Service Service { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public DateTime? DateStarted { get; set; }

        public Order()
        {
            DateStarted = DateTime.Now;
        }


    }
}