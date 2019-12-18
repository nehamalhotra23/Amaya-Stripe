using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Stripe;

namespace Amaya
{
    public class PayModelView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
        public int Amount { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public List<OrderItemOptions> Items { get; set; }
        public int OrderId {get; set;}
        public string Parent { get; set; }
        public List<ShippingOptions> Shipping { get; set; }
        public List<AddressOptions> Address {get; set;}
        public string Line1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Quantity { get; set; } = 2;
        public string PostalCode { get; set; }

    }

}

              