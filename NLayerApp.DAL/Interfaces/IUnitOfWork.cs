using NLayerApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Product> Products { get; }
        IRepository<Phone> Phones { get; }
        IRepository<OrderCustomer> OrderCustomers { get; }
        IRepository<OrderSeller> OrderSellers { get; }
        void Save();
    }
}
