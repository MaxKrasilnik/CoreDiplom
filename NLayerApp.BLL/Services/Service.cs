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

        public void CreateOrderCustomer(OrderCustomerDTO customerDto)
        {
            OrderSeller seller = Database.OrderSellers.Get(customerDto.OrderSellerId);

            // валидация
            if (seller == null)
                throw new ValidationException("Заказ продавца не найден", "");
            // применяем скидку

            OrderCustomer customer = new OrderCustomer
            {
                Name=customerDto.Name,
                Surname=customerDto.Surname,
                Patronymic=customerDto.Patronymic,
                Address=customerDto.Address,
                OrderSellerId=seller.Id,
                OrderSeller=seller

            };
            Database.OrderCustomers.Create(customer);
            Database.Save();
        }

        public OrderCustomerDTO GetOrderCustomer(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderCustomerDTO> GetOrderCustomers()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderCustomer(OrderCustomerDTO customerDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderCustomer(int id)
        {
            throw new NotImplementedException();
        }







        public void CreateOrderSeller(OrderSellerDTO sellerDto)
        {
            if (sellerDto == null)
                throw new ValidationException("При добавлении нового заказа продавца произошла ошибка. Экземпляр объекта OrderSellerDTO равен null.", "");

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderSellerDTO, OrderSeller>()).CreateMapper();
            OrderSeller seller = mapper.Map<OrderSellerDTO, OrderSeller>(sellerDto);

            Database.OrderSellers.Create(seller);
            Database.Save();
        }

        public OrderSellerDTO GetOrderSeller(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderSellerDTO> GetOrderSellers()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderSeller(OrderSellerDTO sellerDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderSeller(int id)
        {


        }







        public void CreatePhone(PhoneDTO phoneDto)
        {
            if(phoneDto == null)
                throw new ValidationException("При добавлении нового телефона произошла ошибка. Экземпляр объекта PhoneDTO равен null.", "");
            if (phoneDto.OrderSellerId == 0)
                throw new ValidationException("Заказ продавца не найден", "");

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PhoneDTO, Phone>()).CreateMapper();
            Phone phone = mapper.Map<PhoneDTO, Phone>(phoneDto);

            OrderSeller seller = Database.OrderSellers.Get(phoneDto.OrderSellerId);
            phone.OrderSeller = seller;

            Database.Phones.Create(phone);
            Database.Save();
        }

        public PhoneDTO GetPhone(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id телефона", "");
            var phone = Database.Phones.Get(id.Value);
            if (phone == null)
                throw new ValidationException("Телефон не найден", "");

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Phone, PhoneDTO>()).CreateMapper();
            return mapper.Map<Phone, PhoneDTO>(phone);
        }

        public IEnumerable<PhoneDTO> GetPhones()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Phone, PhoneDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Phone>, List<PhoneDTO>>(Database.Phones.GetAll());
        }

        public void UpdatePhone(PhoneDTO phoneDto)
        {
            if (phoneDto == null)
                throw new ValidationException("При обновлении телефона произошла ошибка. Экземпляр объекта PhoneDTO равен null.", "");
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PhoneDTO, Phone>()).CreateMapper();
            Phone phone = mapper.Map<PhoneDTO, Phone>(phoneDto);

            Database.Phones.Update(phone);
            Database.Save();
        }

        public void DeletePhone(int id)
        {
            Database.Phones.Delete(id);
            Database.Save();
        }


        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
