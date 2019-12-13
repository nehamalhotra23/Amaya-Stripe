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
//     public class ShopController : Controller
//     {
//         private readonly AmayaContext _db;

//         public ShopController(AmayaContext db)
//         {
//             _db = db;
//         }

//         public IActionResult Index()
//         {
//             return View();
//         }

//         public IActionResult Create(int id)
//         {
//             ViewBag.Id = id;
//             return View();
//         }

//         [HttpPost]
//         public IActionResult Create(Shop shop)
//         {
//             _db.Shop.Add(shop);
//             _db.SaveChanges();
//             return View();
//         }

//         // public IActionResult Create(Shop model)
//         // {
            
        
//         //     var options = new ProductCreateOptions
//         //     {
//         //         Name = "Amaya",
//         //         Type = "beauty",
//         //         Description = "Comfortable cotton t-shirt",
//         //         Attributes = new List<string>
//         //     {
//         //         "size",
//         //         "gender",
//         //     },
//         //     };
//         //     var service = new ProductService();
//         //     service.Create(options);
//   }
// };
    
