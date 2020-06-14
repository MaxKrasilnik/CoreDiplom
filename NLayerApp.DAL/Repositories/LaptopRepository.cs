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
    public class LaptopRepository : IRepository<Laptop>
    {
        private ApplicationContext db;

        public LaptopRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public IEnumerable<Laptop> GetAll()
        {
            return db.Laptops.Include(p => p.Images).Include(p => p.OrderSeller);
        }

        public Laptop Get(int id)
        {
            return db.Laptops.Find(id);
        }

        public void Create(Laptop laptop)
        {
            db.Laptops.Add(laptop);
        }

        public void Update(Laptop laptop)
        {
            db.Entry(laptop).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<Laptop> Find(Func<Laptop, Boolean> predicate)
        {
            return db.Laptops.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Laptop laptop = db.Laptops.Find(id);
            if (laptop != null)
                db.Laptops.Remove(laptop);
        }
    }
}
