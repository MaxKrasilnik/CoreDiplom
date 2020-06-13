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
    public class OrderCustomerRepository : IRepository<OrderCustomer>
    {
        private ApplicationContext db;

        public OrderCustomerRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public IEnumerable<OrderCustomer> GetAll()
        {
            return db.OrderCustomers.Include(i => i.User);
        }

        public OrderCustomer Get(int id)
        {
            return db.OrderCustomers.Find(id);
        }

        public void Create(OrderCustomer orderCustomer)
        {
            db.OrderCustomers.Add(orderCustomer);
        }

        public void Update(OrderCustomer orderCustomer)
        {
            db.Entry(orderCustomer).State = EntityState.Modified;
        }

        public IEnumerable<OrderCustomer> Find(Func<OrderCustomer, Boolean> predicate)
        {
            return db.OrderCustomers.Where(predicate);
        }

        public void Delete(int id)
        {
            OrderCustomer orderCustomer = db.OrderCustomers.Find(id);
            if (orderCustomer != null)
                db.OrderCustomers.Remove(orderCustomer);
        }
    }
}

