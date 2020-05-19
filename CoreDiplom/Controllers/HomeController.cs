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

namespace NLayerApp.WEB
{
    public class HomeController : Controller
    {
        IService service;
        public HomeController(IService serv)
        {
            service = serv;
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
            return View(phoneVM);
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

                return Content("<h2>Ваш заказ успешно оформлен</h2>");
            }
            return View();
        }





        public ActionResult MakeApplicant(PhoneViewModel phone)
        {
            return View();
        }

        public ActionResult MakeOrderCustomer(int? id)
        {
            return View();
            //try
            //{
            //    PhoneDTO phone = service.GetPhone(id);
            //    var order = new OrderViewModel { PhoneId = phone.Id };

            //    return View(order);
            //}
            //catch (ValidationException ex)
            //{
            //    return Content(ex.Message);
            //}
        }
        [HttpPost]
        public ActionResult MakeOrder(OrderCustomerViewModel order)
        {
            try
            {
                var orderDto = new OrderCustomerDTO { Name=order.Name, Surname=order.Surname, Patronymic=order.Patronymic, Address=order.Address, OrderSellerId=order.OrderSellerId };
                service.CreateOrderCustomer(orderDto);
                return Content("<h2>Ваш заказ успешно оформлен</h2>");
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
            }
            return View(order);
        }
        protected override void Dispose(bool disposing)
        {
            service.Dispose();
            base.Dispose(disposing);
        }
    }
}
