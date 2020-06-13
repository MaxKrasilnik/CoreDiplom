using NLayerApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerApp.WEB.Models
{
    public class OrderSellerViewModel
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }

        public Product Product { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
