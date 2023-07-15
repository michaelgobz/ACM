using System;
using System.Collections.Generic;


namespace acm.BL{

    public class Order
    {
        private int _orderId;
        public DateTimeOffset? OrderDate {get; set;}

        public int orderId {
            get;
            private set {
                _orderId = value;
            }
        }

        public Order()
        {

        }

        public Order(int id)
        {
            orderId = id;
        }

        public Order Retrieve(int Id)
        {
            return new Product();
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public bool Validate()
        {
            var isValid = true;
            if (dateTimeOffset.IsNullOrWhiteSpace(productName)) isValid = false;
            if (string.IsNullOrWhiteSpace(productDescription)) isValid = false;
            if (decimal.IsNegative(currentPrice)) isValid = false;

            return isValid;
        }

        public bool save(){
            return true;
        }
    }

}