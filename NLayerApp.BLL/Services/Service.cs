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

        //--------------------Phone---------------------

        public void CreatePhone(PhoneDTO phoneDto)
        {
            if (phoneDto == null)
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

        public void UpdatePhone(PhoneDTO phoneDto)
        {
            if (phoneDto == null)
                throw new ValidationException("При обновлении телефона произошла ошибка. Экземпляр объекта PhoneDTO равен null.", "");
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PhoneDTO, Phone>()).CreateMapper();
            Phone phone = mapper.Map<PhoneDTO, Phone>(phoneDto);

            Database.Phones.Update(phone);
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

        public List<PhoneDTO> GetPhones()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Phone, PhoneDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Phone>, List<PhoneDTO>>(Database.Phones.GetAll());
        }

        public void DeletePhone(int id)
        {
            Database.Phones.Delete(id);
            Database.Save();
        }




        //--------------------OrderSeller---------------------

        public void CreateOrderSeller(OrderSellerDTO sellerDto)
        {
            if (sellerDto == null)
                throw new ValidationException("При добавлении нового заказа продавца произошла ошибка. Экземпляр объекта OrderSellerDTO равен null.", "");

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderSellerDTO, OrderSeller>()).CreateMapper();
            OrderSeller seller = mapper.Map<OrderSellerDTO, OrderSeller>(sellerDto);

            Database.OrderSellers.Create(seller);
            Database.Save();
        }

        public void UpdateOrderSeller(OrderSellerDTO sellerDto)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderSellerDTO, OrderSeller>()).CreateMapper();
            OrderSeller seller = mapper.Map<OrderSellerDTO, OrderSeller>(sellerDto);

            Database.OrderSellers.Update(seller);
            Database.Save();
        }

        public OrderSellerDTO GetOrderSeller(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id объявления продавца", "");
            var seller = Database.OrderSellers.Get(id.Value);
            if (seller == null)
                throw new ValidationException("Объявление продавца не найдено", "");

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderSeller, OrderSellerDTO>()).CreateMapper();
            return mapper.Map<OrderSeller, OrderSellerDTO>(seller);
        }

        public IEnumerable<OrderSellerDTO> GetOrderSellers()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<IEnumerable<OrderSeller>, List<OrderSellerDTO>>()).CreateMapper();
            return mapper.Map<IEnumerable<OrderSeller>, List<OrderSellerDTO>>(Database.OrderSellers.GetAll());
        }

        public void DeleteOrderSeller(int id)
        {
            Database.OrderSellers.Delete(id);
            Database.Save();
        }




        //--------------------OrderCustomer---------------------

        public void CreateOrderCustomer(OrderCustomerDTO customerDto)
        {
            if (customerDto == null)
                throw new ValidationException("При добавлении нового заказа покупателя произошла ошибка. Экземпляр объекта OrderCustomerDTO равен null.", "");

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderCustomerDTO, OrderCustomer>()).CreateMapper();
            OrderCustomer customer = mapper.Map<OrderCustomerDTO, OrderCustomer>(customerDto);

            Database.OrderCustomers.Create(customer);
            Database.Save();
        }

        public void UpdateOrderCustomer(OrderCustomerDTO customerDto)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderCustomerDTO, OrderCustomer>()).CreateMapper();
            OrderCustomer customer = mapper.Map<OrderCustomerDTO, OrderCustomer>(customerDto);

            Database.OrderCustomers.Update(customer);
            Database.Save();
        }

        public OrderCustomerDTO GetOrderCustomer(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id объявления покупателя", "");
            var customer = Database.OrderCustomers.Get(id.Value);
            if (customer == null)
                throw new ValidationException("Объявление покупателя не найдено", "");

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderCustomer, OrderCustomerDTO>()).CreateMapper();
            return mapper.Map<OrderCustomer, OrderCustomerDTO>(customer);
        }

        public IEnumerable<OrderCustomerDTO> GetOrderCustomers()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<IEnumerable<OrderCustomer>, List<OrderCustomerDTO>>()).CreateMapper();
            return mapper.Map<IEnumerable<OrderCustomer>, List<OrderCustomerDTO>>(Database.OrderCustomers.GetAll());
        }

        public void DeleteOrderCustomer(int id)
        {
            Database.OrderCustomers.Delete(id);
            Database.Save();
        }



        //--------------------Image---------------------

        public void CreateImage(ImageDTO imageDto)
        {
            if (imageDto == null)
                throw new ValidationException("При добавлении нового изображения произошла ошибка. Экземпляр объекта ImageDTO равен null.", "");

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ImageDTO, Image>()).CreateMapper();
            Image image = mapper.Map<ImageDTO, Image>(imageDto);

            Database.Images.Create(image);
            Database.Save();
        }

        public void UpdateImage(ImageDTO imageDto)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ImageDTO, Image>()).CreateMapper();
            Image image = mapper.Map<ImageDTO, Image>(imageDto);

            Database.Images.Update(image);
            Database.Save();
        }

        public ImageDTO GetImage(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id изображения", "");
            var image = Database.Images.Get(id.Value);
            if (image == null)
                throw new ValidationException("Изображение не найдено", "");

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Image, ImageDTO>()).CreateMapper();
            return mapper.Map<Image, ImageDTO>(image);
        }

        public IEnumerable<ImageDTO> GetImages()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Image, ImageDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Image>, List<ImageDTO>>(Database.Images.GetAll());
        }

        public void DeleteImage(int id)
        {
            Database.Images.Delete(id);
            Database.Save();
        }




        //--------------------User---------------------

        public void CreateUser(UserDTO userDto)
        {
            if (userDto == null)
                throw new ValidationException("При добавлении нового пользователя произошла ошибка. Экземпляр объекта UserDTO равен null.", "");

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserDTO, User>()).CreateMapper();
            User user = mapper.Map<UserDTO, User>(userDto);

            Database.Users.Create(user);
            Database.Save();
        }

        public void UpdateUser(UserDTO userDto)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserDTO, User>()).CreateMapper();
            User user = mapper.Map<UserDTO, User>(userDto);

            Database.Users.Update(user);
            Database.Save();
        }

        public UserDTO GetUser(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id пользователя", "");
            var user = Database.Users.Get(id.Value);
            if (user == null)
                throw new ValidationException("Пользователь не найден", "");

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>()).CreateMapper();
            return mapper.Map<User, UserDTO>(user);
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<User>, List<UserDTO>>(Database.Users.GetAll());
        }

        public void DeleteUser(int id)
        {
            Database.Users.Delete(id);
            Database.Save();
        }



        //--------------------Product---------------------

        public string GetProduct(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id", "");
            var product = Database.Products.Get(id.Value);
            if (product == null)
                throw new ValidationException("Hе найден", "");

            return product.Category;
        }




        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
