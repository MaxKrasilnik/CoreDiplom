using NLayerApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerApp.WEB.Models
{
    public class OrderCustomerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Address { get; set; }

        public int OrderSellerId { get; set; }
        public OrderSeller OrderSeller { get; set; }
    }
}
