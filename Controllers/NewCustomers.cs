using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Amaya.Models;
using Microsoft.Extensions.Options;
using Stripe;

namespace Amaya.Controllers
{
    public class NewCustomersController : Controller
    {
        private readonly AmayaContext _db;

        public NewCustomersController(AmayaContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(int id)
        {   
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public IActionResult Create(NewCustomers customer)
        {
            _db.NewCustomers.Add(customer);
            _db.SaveChanges();
            return View();
        }
    }
}
