using NLayerApp.BLL.DTO;
using NLayerApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BLL.Interfaces
{
    public interface IService
    {
        void CreateOrderCustomer(OrderCustomerDTO customerDto);
        OrderCustomerDTO GetOrderCustomer(int? id);
        IEnumerable<OrderCustomerDTO> GetOrderCustomers();
        void UpdateOrderCustomer(OrderCustomerDTO customerDto);
        void DeleteOrderCustomer(int id);

        void CreateOrderSeller(OrderSellerDTO sellerDto);
        OrderSellerDTO GetOrderSeller(int? id);
        IEnumerable<OrderSellerDTO> GetOrderSellers();
        void UpdateOrderSeller(OrderSellerDTO sellerDto);
        void DeleteOrderSeller(int id);

        void CreatePhone(PhoneDTO phoneDto);
        PhoneDTO GetPhone(int? id);
        List<PhoneDTO> GetPhones();
        void UpdatePhone(PhoneDTO phoneDto);
        void DeletePhone(int id);

        void CreateImage(ImageDTO imageDto);
        ImageDTO GetImage(int? id);
        IEnumerable<ImageDTO> GetImages();
        void UpdateImage(ImageDTO imageDto);
        void DeleteImage(int id);

        void CreateUser(UserDTO userDto);
        UserDTO GetUser(int? id);
        IEnumerable<UserDTO> GetUsers();
        void UpdateUser(UserDTO userDto);
        void DeleteUser(int id);

        string GetProduct(int? id);

        void Dispose();
    }
}
