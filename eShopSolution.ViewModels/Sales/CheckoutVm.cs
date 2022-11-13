using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Sales
{
    public class CheckoutVm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}