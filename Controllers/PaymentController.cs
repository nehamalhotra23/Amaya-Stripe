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
       
    //         var service = new OrderService();
    //         var options = service.Create (new OrderCreateOptions
    //         {
               
    //             Currency = "usd",
    //             Email = model.Email,
    //             Items = new List<OrderItemOptions> {
    //             new OrderItemOptions {

    //            Amount = (model.Total * 100),
    //             Type = model.Type,
    //             Parent = "sku_GLdbjkfZychwTo",
    //             Quantity = (model.Quantity * 2),
    //     },
    // },
    //          Shipping = new ShippingOptions
    //             {
    //                 Name = model.Name,
    //                 Address = new AddressOptions
    //                 {
    //                     Line1 = "1234 Main Street",
    //                     City = "San Francisco",
    //                     State = "CA",
    //                     Country = "US",
    //                     PostalCode = "94111",
    //                 },
    //             }
    //         });
         

    //         return View();
        
        public IActionResult Charge(PayModelView model)
        {
            var customers = new CustomerService();
            var charges = new ChargeService();

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
                Quantity = (model.Quantity * 2),
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
            var servicepay = new OrderService();
            servicepay.Pay(
              "or_1Fp47BFdC5geAjgF44ULnWwO",
              optionpay
            );
           
                  var charge = charges.Create(new ChargeCreateOptions
                {
                    Currency = "usd",
                    Amount = (model.Amount * 100),
                    Customer = customer.Id,
                    ReceiptEmail = model.Email,

                });
            return View();
        }
        

        
    }

}


    
    

