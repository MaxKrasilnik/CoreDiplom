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
    public class OrderSellerRepository : IRepository<OrderSeller>
    {
        private ApplicationContext db;

        public OrderSellerRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public IEnumerable<OrderSeller> GetAll()
        {
            return db.OrderSellers.Include(o => o.Product).Include(o=>o.OrderCustomers);
        }

        public OrderSeller Get(int id)
        {
            return db.OrderSellers.Find(id);
        }

        public void Create(OrderSeller orderSeller)
        {
            db.OrderSellers.Add(orderSeller);
        }

        public void Update(OrderSeller orderSeller)
        {
            db.Entry(orderSeller).State = EntityState.Modified;
        }

        public IEnumerable<OrderSeller> Find(Func<OrderSeller, Boolean> predicate)
        {
            return db.OrderSellers.Include(o => o.Product)
                .Include(o=>o.OrderCustomers).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            OrderSeller orderSeller = db.OrderSellers.Find(id);
            if (orderSeller != null)
                db.OrderSellers.Remove(orderSeller);
        }
    }
}
