using NLayerApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerApp.WEB.Models
{
    public class LaptopViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Category { get; set; }
        public int PriceStart { get; set; }
        public int PriceNow { get; set; }
        public int PriceEnd { get; set; }
        public int QtyStart { get; set; }
        public int QtyEnd { get; set; }

        public int OrderSellerId { get; set; }
        public OrderSeller OrderSeller { get; set; }

        public List<Image> Images { get; set; }

        public int Screen { get; set; }//Диагональ экрана
        public string CPU { get; set; }//Процессор
        public string RAM { get; set; }//Оперативная память
        public string Memory { get; set; }//Память устройства
        public string Weight { get; set; }//Вес
    }
}
