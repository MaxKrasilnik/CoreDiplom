using NLayerApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerApp.WEB.Models
{
    public class ImageViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        public int? ProductId { get; set; }
        public Product Product { get; set; }
    }
}
