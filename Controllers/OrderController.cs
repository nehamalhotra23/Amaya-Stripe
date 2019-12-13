// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Amaya.Models;
// using Microsoft.Extensions.Options;
// using Stripe;


// namespace Amaya.Controllers
// {
//     public class OrderController : Controller
//     {
//         public IActionResult Index()
//         {
//             return View();
//         }

//         public IActionResult Privacy()
//         {
//             return View();
//         }
//         public IActionResult Create(Order model)
//         {
//             var service = new OrderService();
//             var options = service.Create(new OrderCreateOptions
//             {
//                 Email = model.Email,
//                 Items = new List<OrderItemOptions>
//             {
//                 new OrderItemOptions
//                 {
//                 Type = model.Type,
//                 Parent = model.Parent,
//                 Quantity = model.Quantity
//                 },
//             },
//                 Shipping = new ShippingOptions
//                 {
//                     Name = model.Name,
//                     Address = new AddressOptions
//                     {
//                     Line1 = model.Line1,
//                     City = model.City,
//                     State = model.State,
//                     Country = model.Country,
//                     PostalCode =model.PostalCode
//                     },
//                 }
//                 });
            
              

//         return View() ;
//         }
//     }

// }





