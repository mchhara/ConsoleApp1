using ConsoleApp2.Models;
using ConsoleApp2.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    public class QuoteTotalPriceCalculation : IQuoteTotalPriceCalculation
    {
        private readonly Quote _quote;

        public QuoteTotalPriceCalculation(Quote quote)
        {
            _quote = quote;
        }

        public decimal CalculateTotalPrice() 
        {
            var products = _quote.Products;
            var totalPrice = 0.0m;

            foreach (var product in products)
            {
                totalPrice += product.Price.Value;
            }

            return totalPrice;
        }
    }
}
