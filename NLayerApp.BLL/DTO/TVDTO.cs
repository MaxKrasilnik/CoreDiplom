using NLayerApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BLL.DTO
{
    public class TVDTO
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

        public IEnumerable<Image> Images { get; set; }

        public int Screen { get; set; }//Диагональ экрана
        public string Resolution { get; set; }//Разрешение экрана
        public string TunerRanges { get; set; }//Диапазоны цифрового тюнера
        public string SmartPlatform { get; set; }//Smart-платформа
        public string DimensionsWithStand { get; set; }//Размеры с подставкой
        public string WeightWithStand { get; set; }//Вес с подставкой
    }
}
