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
    public class PhoneRepository : IRepository<Phone>
    {
        private ApplicationContext db;

        public PhoneRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public IEnumerable<Phone> GetAll()
        {
            return db.Phones.Include(p=>p.Images).Include(p=>p.OrderSeller);
        }

        public Phone Get(int id)
        {

            return db.Phones.Find(id);
        }

        public void Create(Phone phone)
        {
            db.Phones.Add(phone);
        }

        public void Update(Phone phone)
        {
            db.Entry(phone).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<Phone> Find(Func<Phone, Boolean> predicate)
        {
            return db.Phones.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Phone phone = db.Phones.Find(id);
            if (phone != null)
                db.Phones.Remove(phone);
        }
    }
}
