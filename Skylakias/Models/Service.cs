using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Skylakias.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Display(Name = "Price")]
        [Column(TypeName = "money")]
        [Required]
        public decimal Price { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}