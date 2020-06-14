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
    public class TVRepository : IRepository<TV>
    {
        private ApplicationContext db;

        public TVRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public IEnumerable<TV> GetAll()
        {
            return db.TVs.Include(p => p.Images).Include(p => p.OrderSeller);
        }

        public TV Get(int id)
        {

            return db.TVs.Find(id);
        }

        public void Create(TV tv)
        {
            db.TVs.Add(tv);
        }

        public void Update(TV tv)
        {
            db.Entry(tv).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<TV> Find(Func<TV, Boolean> predicate)
        {
            return db.TVs.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            TV tv = db.TVs.Find(id);
            if (tv != null)
                db.TVs.Remove(tv);
        }
    }
}
