using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DAL.Entities
{
    public class Phone: Product
    {
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
