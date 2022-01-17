using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Skylakias.Models;

namespace Skylakias.ViewModels
{
    public class CreateOrdersViewModel
    {
        public string ApplicationUserId { get; set; }
        public int ServiceId { get; set; }
        public List<Service> Services { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal TotalPrice { get; set; }
        public Service Service { get; set; }


    }
}