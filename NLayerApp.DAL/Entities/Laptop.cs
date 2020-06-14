using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DAL.Entities
{
    public class Laptop : Product
    {
        public int Screen { get; set; }//Диагональ экрана
        public string CPU { get; set; }//Процессор
        public string RAM { get; set; }//Оперативная память
        public string Memory { get; set; }//Память устройства
        public string Weight { get; set; }//Вес
    }
}
