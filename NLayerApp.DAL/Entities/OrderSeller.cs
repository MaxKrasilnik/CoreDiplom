using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DAL.Entities
{
    public class OrderSeller
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }

        public Product Product { get; set; }
        public ICollection<OrderCustomer> OrderCustomers { get; set; }
    }
}
