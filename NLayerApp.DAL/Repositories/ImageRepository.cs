using Microsoft.EntityFrameworkCore;
using NLayerApp.DAL.EF;
using NLayerApp.DAL.Entities;
using NLayerApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DAL.Repositories
{
    public class ImageRepository : IRepository<Image>
    {
        private ApplicationContext db;

        public ImageRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public IEnumerable<Image> GetAll()
        {
            return db.Images.Include(i=>i.Product);
        }

        public Image Get(int id)
        {
            return db.Images.Find(id);
        }

        public void Create(Image image)
        {
            db.Images.Add(image);
        }

        public void Update(Image image)
        {
            db.Entry(image).State = EntityState.Modified;
        }

        public IEnumerable<Image> Find(Func<Image, Boolean> predicate)
        {
            return db.Images.Where(predicate);
        }

        public void Delete(int id)
        {
            Image image = db.Images.Find(id);
            if (image != null)
                db.Images.Remove(image);
        }
    }
}
