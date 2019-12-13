using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Amaya;
using Microsoft.Extensions.Options;
using Stripe;


namespace Amaya.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Charge(PayModelView model)
        {
            var customers = new CustomerService();
            var customer = customers.Create(new CustomerCreateOptions
            {
                Name = model.Name,
                Email = model.Email,
                Source = model.Token
            });
            var service = new OrderService();
            var options = service.Create(new OrderCreateOptions
            {
                Currency = "usd",
                Email = model.Email,
                Items = new List<OrderItemOptions> {
                new OrderItemOptions {
                Type = model.Type,
                Parent = "sku_GLdbjkfZychwTo",
                Quantity = model.Quantity,
        },
    },
                Shipping = new ShippingOptions
                {
                    Name = model.Name,
                    Address = new AddressOptions
                    {
                        Line1 = "1234 Main Street",
                        City = "San Francisco",
                        State = "CA",
                        Country = "US",
                        PostalCode = "94111",
                    },
                }
            });

            var optionpay = new OrderPayOptions
            {
                Customer = customer.Id,
            };
            service.Pay(
              options.Id,
              optionpay
            );
            return View();
        }



    }

}





