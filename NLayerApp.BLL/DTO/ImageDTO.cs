using NLayerApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BLL.DTO
{
    public class ImageDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
