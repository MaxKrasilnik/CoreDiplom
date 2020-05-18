using NLayerApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerApp.WEB.Models
{
    public class PhoneViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Manufacturer { get; set; }
        public string Category { get; set; }

        public int OrderSellerId { get; set; }
        public OrderSeller OrderSeller { get; set; }

        public double Screen { get; set; }//размер экрана
        public string CPU { get; set; }//процессор
        public string Camera { get; set; }//камера
        public int RAM { get; set; }//оперативная память
        public int Memory { get; set; }//память устройства
        public int QtySimCard { get; set; }//количество SIM-карт
        public int Charge { get; set; }//объем заряда устройства
        public string OperationSystem { get; set; }//операционная система
    }
}
