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


        void CreateTV(TVDTO tvDto);
        TVDTO GetTV(int? id);
        List<TVDTO> GetTVs();
        void UpdateTV(TVDTO tvDto);
        void DeleteTV(int id);

        void CreateLaptop(LaptopDTO laptopDto);
        LaptopDTO GetLaptop(int? id);
        List<LaptopDTO> GetLaptops();
        void UpdateLaptop(LaptopDTO laptopDto);
        void DeleteLaptop(int id);

        void Dispose();
    }
}
