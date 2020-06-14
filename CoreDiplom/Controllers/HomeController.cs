using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLayerApp.BLL.Interfaces;
using NLayerApp.BLL.DTO;
using AutoMapper;
using NLayerApp.WEB.Models;
using NLayerApp.BLL.Infrastructure;
using NLayerApp.BLL.Services;
using NLayerApp.DAL.Entities;
using System.Net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Reflection;

namespace NLayerApp.WEB
{
    public class HomeController : Controller
    {
        IService service;
        IWebHostEnvironment _appEnvironment;
        static bool authorization = false;
        static int authorizUserId = 0;
        int orderSelId=0;

        public HomeController(IService serv, IWebHostEnvironment appEnvironment)
        {
            service = serv;
            _appEnvironment = appEnvironment;
        }

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult UserCabinet(string email, string password)
        {
            IEnumerable<UserDTO> users = service.GetUsers();
            UserDTO needUser;
            try
            {
                needUser = users.Where(u => u.Email == email && u.Password == password)
                .First();
            }
            catch(Exception ex)
            {
                return View("Index");
            }

            authorization = true;
            authorizUserId = needUser.Id;
            //OrderSellerDTO order = service.GetOrderSeller(1);


            /*var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PhoneDTO, PhoneViewModel>()).CreateMapper();
            List<PhoneViewModel> phoneVMs = mapper.Map<List<PhoneDTO>, List<PhoneViewModel>>(service.GetPhones());

            int page = 1;
            int pageSize = 3; // количество объектов на страницу
            IEnumerable<PhoneViewModel> phonesPerPages = phoneVMs.Skip((page - 1) * pageSize).Take(pageSize);
            PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = phoneVMs.Count };
            IndexViewModel ivm = new IndexViewModel { PageInfo = pageInfo, Phones = phonesPerPages };
            return View(ivm);*/
            return View();
        }

        public ActionResult GetInfo()
        {
            return PartialView("");
        }





        //--------------------Image---------------------



        [HttpGet]
        public ActionResult CreateImage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateImage(IFormFile fileImage)
        {
            if (fileImage != null)
            {
                // путь к папке Files
                string path = "/images/" + fileImage.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using(var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    fileImage.CopyTo(fileStream);
                }


                PhoneDTO phoneDto = service.GetPhone(1);
                //var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PhoneDTO,
                //    Phone>()).CreateMapper();
                //Phone phone = mapper.Map<PhoneDTO, Phone>(phoneDto);

                ImageViewModel imageVM = new ImageViewModel { Name = fileImage.FileName, Path = path, ProductId = phoneDto.Id };
                var mapper1 = new MapperConfiguration(cfg => cfg.CreateMap<ImageViewModel,
                    ImageDTO>()).CreateMapper();
                ImageDTO imageDto = mapper1.Map<ImageViewModel, ImageDTO>(imageVM);
                service.CreateImage(imageDto);
            }

            return View();
        }

        public ActionResult GetImages()
        {
            IEnumerable<ImageDTO> imageDtos = service.GetImages();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ImageDTO,
                    ImageViewModel>()).CreateMapper();
            List<ImageViewModel> imageVM = mapper.Map<IEnumerable<ImageDTO>, List<ImageViewModel>>(imageDtos);

            return View(imageVM);
        }




        //--------------------Phone---------------------

        [HttpGet]
        public ActionResult CreatePhone()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePhone(PhoneViewModel phoneVM)
        {
            if (ModelState.IsValid)
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PhoneViewModel,
                    PhoneDTO>()).CreateMapper();
                PhoneDTO phoneDto = mapper.Map<PhoneViewModel, PhoneDTO>(phoneVM);
                service.CreatePhone(phoneDto);

                return Content("<h2>Ваш заказ успешно оформлен</h2>");
            }
            return View();
        }

        [HttpGet]
        public ActionResult UpdatePhone(int phoneIdDto)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PhoneDTO, PhoneViewModel>()).CreateMapper();
            PhoneViewModel phoneVM = mapper.Map<PhoneDTO, PhoneViewModel>(service.GetPhone(phoneIdDto));

            return View(phoneVM);
        }

        [HttpPost]
        public ActionResult UpdatePhone(PhoneViewModel phoneVM)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PhoneViewModel, PhoneDTO>()).CreateMapper();
            PhoneDTO phoneDto = mapper.Map<PhoneViewModel, PhoneDTO>(phoneVM);
            service.UpdatePhone(phoneDto);

            return View("Index");
        }

        [HttpGet]
        public ActionResult UpdatePhoneCust(PhoneViewModel phoneVM)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PhoneViewModel, PhoneDTO>()).CreateMapper();
            PhoneDTO phoneDto = mapper.Map<PhoneViewModel, PhoneDTO>(phoneVM);
            service.UpdatePhone(phoneDto);

            return View("Index");
        }


        public void UpdatePhoneCustomer(PhoneViewModel phoneVM)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PhoneViewModel, PhoneDTO>()).CreateMapper();
            PhoneDTO phoneDto = mapper.Map<PhoneViewModel, PhoneDTO>(phoneVM);
            service.UpdatePhone(phoneDto);
        }

        public ActionResult GetPhone(int phoneIdDto)
        {
            PhoneDTO phoneDTO = service.GetPhone(phoneIdDto);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PhoneDTO, PhoneViewModel>()).CreateMapper();
            PhoneViewModel phoneVM = mapper.Map<PhoneDTO, PhoneViewModel>(phoneDTO);

            var mapper1 = new MapperConfiguration(cfg => cfg.CreateMap<ImageDTO, Image>()).CreateMapper();
            IEnumerable<Image> images = mapper1.Map<IEnumerable<ImageDTO>, IEnumerable<Image>>(service.GetImages());

            phoneVM.Images.AddRange(images.Where(i => i.ProductId == phoneVM.Id));

            var mapper2 = new MapperConfiguration(cfg => cfg.CreateMap<OrderSellerDTO, OrderSeller>()).CreateMapper();
            OrderSeller seller = mapper2.Map<OrderSellerDTO, OrderSeller>(service.GetOrderSeller(phoneVM.OrderSellerId));

            phoneVM.OrderSeller = seller;

            return View(phoneVM);
        }

        public ActionResult GetPhones()
        {
            List<PhoneDTO> phoneDTOs = service.GetPhones();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PhoneDTO, PhoneViewModel>()).CreateMapper();
            List<PhoneViewModel> phoneVMs = mapper.Map<List<PhoneDTO>, List<PhoneViewModel>>(phoneDTOs);

            return View(phoneVMs);
        }

        [HttpPost]
        public ActionResult GetPhonesSort(string[] filters)
        {
            List<PhoneDTO> phoneDTOs = service.GetPhones();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PhoneDTO, PhoneViewModel>()).CreateMapper();
            List<PhoneViewModel> phoneVMs = mapper.Map<List<PhoneDTO>, List<PhoneViewModel>>(phoneDTOs);

            List<PhoneViewModel> rezult = new List<PhoneViewModel>();


            for(int i =0; i < filters.Length; i++)
            {
                switch(filters[i])
                {
                    case "Samsung":
                        rezult.AddRange(phoneVMs.Where(p => p.Manufacturer == "Samsung"));
                        break;
                    case "Apple":
                        rezult.AddRange(phoneVMs.Where(p => p.Manufacturer == "Apple"));
                        break;
                    case "ASUS":
                        rezult.AddRange(phoneVMs.Where(p => p.Manufacturer == "ASUS"));
                        break;
                    case "6":
                        rezult.AddRange(phoneVMs.Where(p => p.Screen == 6));
                        break;
                    case "6,5":
                        rezult.AddRange(phoneVMs.Where(p => p.Screen == 6.5));
                        break;
                    case "8":
                        rezult.AddRange(phoneVMs.Where(p => p.Screen == 8));
                        break;
                    case "4 Гб":
                        rezult.AddRange(phoneVMs.Where(p => p.RAM == 4));
                        break;
                    case "8 Гб":
                        rezult.AddRange(phoneVMs.Where(p => p.RAM == 8));
                        break;
                    case "Android":
                        rezult.AddRange(phoneVMs.Where(p => p.OperationSystem == "Android"));
                        break;
                    case "IOS":
                        rezult.AddRange(phoneVMs.Where(p => p.OperationSystem == "IOS"));
                        break;
                }
            }

            return View("GetPhones", rezult.Distinct().ToList());
        }

        [HttpGet]
        public ActionResult DeletePhone(int? phoneIdDto)
        {
            if (phoneIdDto == null)
            {
                throw new ValidationException("Не установлено id телефона", "");
            }
            PhoneDTO phoneDto = service.GetPhone(phoneIdDto);
            if (phoneDto == null)
            {
                throw new ValidationException("Такого телефона не существует", "");
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PhoneDTO, PhoneViewModel>()).CreateMapper();
            PhoneViewModel phoneVM = mapper.Map<PhoneDTO, PhoneViewModel>(phoneDto);
            return View(phoneVM);
        }

        [HttpPost]
        public ActionResult DeletePhone(PhoneViewModel phoneVM)
        {
            service.DeletePhone(phoneVM.Id);
            return Content("<h2>Телефон удален</h2>");
        }




        //--------------------OrderSeller---------------------

        [HttpGet]
        public ActionResult CreateOrderSeller()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateOrderSeller(OrderSellerViewModel sellerVM)
        {
            if (ModelState.IsValid)
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderSellerViewModel,
                    OrderSellerDTO>()).CreateMapper();
                OrderSellerDTO sellerDto = mapper.Map<OrderSellerViewModel, OrderSellerDTO>(sellerVM);
                service.CreateOrderSeller(sellerDto);

                return View("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult UpdateOrderSeller(int sellerIdDto)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderSellerDTO, OrderSellerViewModel>()).CreateMapper();
            OrderSellerViewModel sellerVM = mapper.Map<OrderSellerDTO, OrderSellerViewModel>(service.GetOrderSeller(sellerIdDto));

            return View(sellerVM);
        }

        [HttpPost]
        public ActionResult UpdateOrderSeller(OrderSellerViewModel sellerVM)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderSellerViewModel, OrderSellerDTO>()).CreateMapper();
            OrderSellerDTO sellerDto = mapper.Map<OrderSellerViewModel, OrderSellerDTO>(sellerVM);
            service.UpdateOrderSeller(sellerDto);

            return Content("<div style='text-align: center;'><h2>Изменения сохранены успешно</h2></div>");
        }

        public ActionResult GetOrderSeller(int sellerIdDto)
        {
            OrderSellerDTO sellerDTO = service.GetOrderSeller(sellerIdDto);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderSellerDTO, OrderSellerViewModel>()).CreateMapper();
            OrderSellerViewModel sellerVM = mapper.Map<OrderSellerDTO, OrderSellerViewModel>(sellerDTO);
            return View(sellerVM);
        }

        [HttpGet]
        public ActionResult DeleteOrderSeller(int? sellerIdDto)
        {
            if (sellerIdDto == null)
            {
                throw new ValidationException("Не установлено id объявления продавца", "");
            }
            OrderSellerDTO sellerDto = service.GetOrderSeller(sellerIdDto);
            if (sellerDto == null)
            {
                throw new ValidationException("Объявления продавца не существует", "");
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderSellerDTO, OrderSellerViewModel>()).CreateMapper();
            OrderSellerViewModel sellerVM = mapper.Map<OrderSellerDTO, OrderSellerViewModel>(sellerDto);
            return View(sellerVM);
        }

        [HttpPost]
        public ActionResult DeleteOrderSeller(OrderSellerViewModel sellerVM)
        {
            service.DeleteOrderSeller(sellerVM.Id);
            return Content("<h2>Объявление продавца удалено</h2>");
        }






        //--------------------OrderCustomer---------------------
        [HttpGet]
        public ActionResult CreateOrderCustomer(int prodId)
        {
            ViewData["prodId"] = prodId;
            if (authorization == false && authorizUserId == 0)
            {
                return View("Authorization");
            }
            authorization = true;
            ViewData["UserId"] = authorizUserId;

            return View();
        }


        [HttpPost]
        public ActionResult CreateOrderCustomerAfterAuthorization(string email, string password, int prodId)
        {
            IEnumerable<UserDTO> users = service.GetUsers();
            UserDTO needUser;
            try
            {
                needUser = users.Where(u => u.Email == email && u.Password == password)
                .First();
            }
            catch (Exception ex)
            {
                ViewData["prodId"] = prodId;
                return View("Authorization");
            }

            authorization = true;
            authorizUserId = needUser.Id;

            ViewData["prodId"] = prodId;
            ViewData["UserId"] = authorizUserId;

            return View("CreateOrderCustomer");
        }


        int Price(int priceStart, int priceEnd, int qty)
        {
            return priceEnd + Convert.ToInt32((priceStart - priceEnd) * 0.1 * qty);
        }


        public ActionResult ProductEnded()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CreateOrderCustomer(OrderCustomerViewModel customerVM)
        {
            if (ModelState.IsValid)
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderCustomerViewModel,
                    OrderCustomerDTO>()).CreateMapper();
                OrderCustomerDTO customerDto = mapper.Map<OrderCustomerViewModel, OrderCustomerDTO>(customerVM);
                service.CreateOrderCustomer(customerDto);

                string category = service.GetProduct(customerVM.ProdId);

                if(category== "Phone")
                {
                    PhoneDTO phoneDTO = service.GetPhone(customerVM.ProdId);

                    if(phoneDTO.QtyEnd==0)
                    {
                        return View("ProductEnded");
                    }

                    phoneDTO.QtyEnd--;
                    phoneDTO.PriceNow = Price(phoneDTO.PriceStart, phoneDTO.PriceEnd, phoneDTO.QtyEnd);


                    var mapper1 = new MapperConfiguration(cfg => cfg.CreateMap<PhoneDTO,
                    PhoneViewModel>()).CreateMapper();
                    PhoneViewModel phoneVM = mapper1.Map<PhoneDTO, PhoneViewModel>(phoneDTO);


                    return View("ThanksPagePhone", phoneVM);
                }

                if (category == "TV")
                {
                    TVDTO tvDTO = service.GetTV(customerVM.ProdId);

                    if (tvDTO.QtyEnd == 0)
                    {
                        return View("ProductEnded");
                    }

                    tvDTO.QtyEnd--;
                    tvDTO.PriceNow = Price(tvDTO.PriceStart, tvDTO.PriceEnd, tvDTO.QtyEnd);


                    var mapper1 = new MapperConfiguration(cfg => cfg.CreateMap<TVDTO,
                    TVViewModel>()).CreateMapper();
                    TVViewModel tvVM = mapper1.Map<TVDTO, TVViewModel>(tvDTO);


                    return View("ThanksPageTV", tvVM);
                }


                return View("ThanksPagePhone");
            }
            return View("ThanksPagePhone");
        }

        [HttpGet]
        public ActionResult UpdateOrderCustomer(int customerIdDto)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderCustomerDTO, OrderCustomerViewModel>()).CreateMapper();
            OrderCustomerViewModel customerVM = mapper.Map<OrderCustomerDTO, OrderCustomerViewModel>(service.GetOrderCustomer(customerIdDto));

            return View(customerVM);
        }

        [HttpPost]
        public ActionResult UpdateOrderCustomer(OrderCustomerViewModel customerVM)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderCustomerViewModel, OrderCustomerDTO>()).CreateMapper();
            OrderCustomerDTO customerDto = mapper.Map<OrderCustomerViewModel, OrderCustomerDTO>(customerVM);
            service.UpdateOrderCustomer(customerDto);

            return Content("<div style='text-align: center;'><h2>Изменения сохранены успешно</h2></div>");
        }

        public ActionResult GetOrderCustomer(int customerIdDto)
        {
            OrderCustomerDTO customerDTO = service.GetOrderCustomer(customerIdDto);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderCustomerDTO, OrderCustomerViewModel>()).CreateMapper();
            OrderCustomerViewModel customerVM = mapper.Map<OrderCustomerDTO, OrderCustomerViewModel>(customerDTO);
            return View(customerVM);
        }

        [HttpGet]
        public ActionResult DeleteOrderCustomer(int? customerIdDto)
        {
            if (customerIdDto == null)
            {
                throw new ValidationException("Не установлено id объявления покупателя", "");
            }
            OrderCustomerDTO customerDto = service.GetOrderCustomer(customerIdDto);
            if (customerDto == null)
            {
                throw new ValidationException("Объявления покупателя не существует", "");
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OrderCustomerDTO, OrderCustomerViewModel>()).CreateMapper();
            OrderCustomerViewModel customerVM = mapper.Map<OrderCustomerDTO, OrderCustomerViewModel>(customerDto);
            return View(customerVM);
        }

        [HttpPost]
        public ActionResult DeleteOrderCustomer(OrderCustomerViewModel customerVM)
        {
            service.DeleteOrderCustomer(customerVM.Id);
            return Content("<h2>Объявление покупателя удалено</h2>");
        }




        //--------------------User---------------------

        public ActionResult GetUsers()
        {
            IEnumerable<UserDTO> userDTOs = service.GetUsers();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserDTO, UserViewModel>()).CreateMapper();
            List<UserViewModel> userVMs = mapper.Map<List<UserDTO>, List<UserViewModel>>(userDTOs.ToList());

            return View(userVMs);
        }

        [HttpGet]
        public ActionResult CreateUserCust(int prodId)
        {
            ViewData["prodId"] = prodId;
            return View();
        }

        [HttpPost]
        public ActionResult CreateUserCust(UserViewModel userVM, int prodId)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserViewModel, UserDTO>()).CreateMapper();
            UserDTO userDto = mapper.Map<UserViewModel, UserDTO>(userVM);
            service.CreateUser(userDto);

            ViewData["prodId"] = prodId;

            authorization = true;
            authorizUserId = service.GetUsers().Last().Id;

            ViewData["UserId"] = service.GetUsers().Last().Id;

            return View("CreateOrderCustomer");
        }






        //--------------------TV---------------------


        public ActionResult GetTVs()
        {
            List<TVDTO> tvDTOs = service.GetTVs();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TVDTO, TVViewModel>()).CreateMapper();
            List<TVViewModel> tvVMs = mapper.Map<List<TVDTO>, List<TVViewModel>>(tvDTOs);

            return View(tvVMs);
        }


        [HttpPost]
        public ActionResult GetTVsSort(string[] filters)
        {
            List<TVDTO> tvDTOs = service.GetTVs();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TVDTO, TVViewModel>()).CreateMapper();
            List<TVViewModel> tvVMs = mapper.Map<List<TVDTO>, List<TVViewModel>>(tvDTOs);

            List<TVViewModel> rezult = new List<TVViewModel>();


            for (int i = 0; i < filters.Length; i++)
            {
                switch (filters[i])
                {
                    case "Samsung":
                        rezult.AddRange(tvVMs.Where(p => p.Manufacturer == "Samsung"));
                        break;
                    case "Xiaomi":
                        rezult.AddRange(tvVMs.Where(p => p.Manufacturer == "Xiaomi"));
                        break;
                    case "Panasonic":
                        rezult.AddRange(tvVMs.Where(p => p.Manufacturer == "Panasonic"));
                        break;
                    case "24":
                        rezult.AddRange(tvVMs.Where(p => p.Screen == 24));
                        break;
                    case "32":
                        rezult.AddRange(tvVMs.Where(p => p.Screen == 32));
                        break;
                    case "43":
                        rezult.AddRange(tvVMs.Where(p => p.Screen == 43));
                        break;
                    case "1366x768":
                        rezult.AddRange(tvVMs.Where(p => p.Resolution == "1366x768"));
                        break;
                    case "3840x2160":
                        rezult.AddRange(tvVMs.Where(p => p.Resolution == "3840x2160"));
                        break;
                    case "Нет":
                        rezult.AddRange(tvVMs.Where(p => p.SmartPlatform == "Нет"));
                        break;
                    case "Android":
                        rezult.AddRange(tvVMs.Where(p => p.SmartPlatform == "Android"));
                        break;
                    case "My Home Screen 3.0":
                        rezult.AddRange(tvVMs.Where(p => p.SmartPlatform == "My Home Screen 3.0"));
                        break;
                }
            }

            return View("GetTVs", rezult.Distinct().ToList());
        }

        public ActionResult GetTV(int tvIdDto)
        {
            TVDTO tvDTO = service.GetTV(tvIdDto);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TVDTO, TVViewModel>()).CreateMapper();
            TVViewModel tvVM = mapper.Map<TVDTO, TVViewModel>(tvDTO);

            var mapper1 = new MapperConfiguration(cfg => cfg.CreateMap<ImageDTO, Image>()).CreateMapper();
            IEnumerable<Image> images = mapper1.Map<IEnumerable<ImageDTO>, IEnumerable<Image>>(service.GetImages());

            tvVM.Images.AddRange(images.Where(i => i.ProductId == tvVM.Id));

            var mapper2 = new MapperConfiguration(cfg => cfg.CreateMap<OrderSellerDTO, OrderSeller>()).CreateMapper();
            OrderSeller seller = mapper2.Map<OrderSellerDTO, OrderSeller>(service.GetOrderSeller(tvVM.OrderSellerId));

            tvVM.OrderSeller = seller;

            return View(tvVM);
        }

        [HttpGet]
        public ActionResult UpdateTVCust(TVViewModel tvVM)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TVViewModel, TVDTO>()).CreateMapper();
            TVDTO tvDto = mapper.Map<TVViewModel, TVDTO>(tvVM);
            service.UpdateTV(tvDto);

            return View("Index");
        }

















        protected override void Dispose(bool disposing)
        {
            service.Dispose();
            base.Dispose(disposing);
        }
    }
}
