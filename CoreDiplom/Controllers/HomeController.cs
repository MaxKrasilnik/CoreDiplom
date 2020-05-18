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
            IEnumerable<PhoneDTO> phoneDtos = service.GetPhones();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PhoneDTO, PhoneViewModel>()).CreateMapper();
            var phones = mapper.Map<IEnumerable<PhoneDTO>, List<PhoneViewModel>>(phoneDtos);
            //return View(new PhoneViewModel { Id = 1, Name = "Phone1", Price = 2000, Manufacturer = "Samsung", Category = "Phone", Screen = 6, CPU = "CPU1", Camera = "Camera1", RAM = 4, Memory = 16, QtySimCard = 2, Charge = 3000, OperationSystem = "Android" });
            return View(phones.First());
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
                service.MakeOrderCustomer(orderDto);
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
