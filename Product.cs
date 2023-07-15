using System;
using System.Collections.Generic;
using acm.Interfaces
namespace acm.BL
{

    public class Product : IEntity
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

        public int entityId
        {
            get 
            {
                return _productId;
            }
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

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(productName)) isValid = false;
            if (string.IsNullOrWhiteSpace(productDescription)) isValid = false;
            if (decimal.IsNegative(currentPrice)) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            var item = $"{entityId}: {productName} : {productDescription}: {currentPrice}";
            return item;
        }

    }

}