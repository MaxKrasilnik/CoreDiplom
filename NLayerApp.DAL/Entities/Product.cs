using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Manufacturer { get; set; }
        public string Category { get; set; }

        public int OrderSellerId { get; set; }
        public OrderSeller OrderSeller { get; set; }

        public ICollection<Image> Images { get; set; }
    }
}
