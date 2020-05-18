using AutoMapper;
using NLayerApp.BLL.DTO;
using NLayerApp.BLL.Infrastructure;
using NLayerApp.BLL.Interfaces;
using NLayerApp.DAL.Entities;
using NLayerApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BLL.Services
{
    public class Service : IService
    {
        IUnitOfWork Database { get; set; }

        public Service(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void MakeOrderCustomer(OrderCustomerDTO orderCustDto)
        {
            OrderSeller orderSeller = Database.OrderSellers.Get(orderCustDto.OrderSellerId);

            // валидация
            if (orderSeller == null)
                throw new ValidationException("Заказ продавца не найден", "");
            // применяем скидку

            OrderCustomer customer = new OrderCustomer
            {
                Name=orderCustDto.Name,
                Surname=orderCustDto.Surname,
                Patronymic=orderCustDto.Patronymic,
                Address=orderCustDto.Address,
                OrderSellerId=orderSeller.Id,
                OrderSeller=orderSeller

            };
            Database.OrderCustomers.Create(customer);
            Database.Save();
        }

        public IEnumerable<PhoneDTO> GetPhones()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Phone, PhoneDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Phone>, List<PhoneDTO>>(Database.Phones.GetAll());
        }

        public PhoneDTO GetPhone(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id телефона", "");
            var phone = Database.Phones.Get(id.Value);
            if (phone == null)
                throw new ValidationException("Телефон не найден", "");

            return new PhoneDTO { Name=phone.Name, Price=phone.Price, Manufacturer=phone.Manufacturer, Category=phone.Category, Screen=phone.Screen, CPU=phone.CPU, Camera=phone.Camera, RAM=phone.RAM, Memory=phone.Memory, QtySimCard=phone.QtySimCard, Charge=phone.Charge, OperationSystem=phone.OperationSystem, OrderSellerId=phone.OrderSellerId, OrderSeller=phone.OrderSeller };
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
