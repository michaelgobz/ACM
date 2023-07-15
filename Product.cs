using System;
using System.Collections.Generic;
namespace acm.BL
{

    public class Product
    {
        private int _productId;
        public string productName { get; set; }
        public string productDescription { get; set; }
        public decimal currentPrice { get; set; }
        public static int instanceCounter
        {
            get;
            set;
        }

        public int productId
        {
            get;
            set
            {
                _productId = value;
            }
        }
        public Product()
        {

        }

        public Product(int Id)
        {
            productId = Id;
        }

        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(productName)) isValid = false;
            if (string.IsNullOrWhiteSpace(productDescription)) isValid = false;
            if (decimal.IsNegative(currentPrice)) isValid = false;

            return isValid;
        }

        public bool Save(){
            return true;
        }

    }

}