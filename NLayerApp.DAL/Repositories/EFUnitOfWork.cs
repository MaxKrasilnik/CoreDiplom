﻿using NLayerApp.DAL.EF;
using NLayerApp.DAL.Entities;
using NLayerApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NLayerApp.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private ApplicationContext db;
        private ProductRepository productRepository;
        private PhoneRepository phoneRepository;
        private OrderCustomerRepository orderCustomerRepository;
        private OrderSellerRepository orderSellerRepository;

        public EFUnitOfWork(ApplicationContext context)
        {
            db = context;
        }

        public IRepository<Product> Products
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(db);
                return productRepository;
            }
        }

        public IRepository<Phone> Phones
        {
            get
            {
                if (phoneRepository == null)
                    phoneRepository = new PhoneRepository(db);
                return phoneRepository;
            }
        }

        public IRepository<OrderCustomer> OrderCustomers
        {
            get
            {
                if (orderCustomerRepository == null)
                    orderCustomerRepository = new OrderCustomerRepository(db);
                return orderCustomerRepository;
            }
        }

        public IRepository<OrderSeller> OrderSellers
        {
            get
            {
                if (orderSellerRepository == null)
                    orderSellerRepository = new OrderSellerRepository(db);
                return orderSellerRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}