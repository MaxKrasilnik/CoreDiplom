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

namespace NLayerApp.WEB
{
    public class HomeController : Controller
    {
        IService service;
        IWebHostEnvironment _appEnvironment;

        public HomeController(IService serv, IWebHostEnvironment appEnvironment)
        {
            service = serv;
            _appEnvironment = appEnvironment;
        }

        public ActionResult Index()
        {
            //IEnumerable<PhoneDTO> phoneDtos = service.GetPhones();
            //var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PhoneDTO, PhoneViewModel>()).CreateMapper();
            //var phones = mapper.Map<IEnumerable<PhoneDTO>, List<PhoneViewModel>>(phoneDtos);

            //return View(phones.First());
            return View();
        }


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

        /*[HttpPost]
        public ActionResult Test(ImageViewModel imageVM)
        {
            if (ModelState.IsValid)
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ImageViewModel, ImageDTO>()).CreateMapper();
                ImageDTO imageDto = mapper.Map<ImageViewModel, ImageDTO>(imageVM);
                service.CreateImage(imageDto);

                return Content("<h2>Ваш заказ успешно оформлен</h2>");
            }
            return View();
        }*/

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

            return Content("<div style='text-align: center;'><h2>Изменения сохранены успешно</h2></div>");
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
        public ActionResult CreateOrderCustomer()
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

                return Content("<h2>Ваш заказ успешно оформлен</h2>");
            }
            return View();
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








        protected override void Dispose(bool disposing)
        {
            service.Dispose();
            base.Dispose(disposing);
        }
    }
}
