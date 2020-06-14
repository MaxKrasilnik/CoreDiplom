using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DAL.Entities
{
    public class TV : Product
    {
        public int Screen { get; set; }//Диагональ экрана
        public string Resolution { get; set; }//Разрешение экрана
        public string TunerRanges { get; set; }//Диапазоны цифрового тюнера
        public string SmartPlatform { get; set; }//Smart-платформа
        public string DimensionsWithStand { get; set; }//Размеры с подставкой
        public string WeightWithStand { get; set; }//Вес с подставкой
    }
}
