using System;
using System.Collections.Generic;


namespace acm.BL{

    public class Order
    {
        private int _orderId;
        public DateTimeOffset? OrderDate {get; 
        set {
            OrderDate = DateTimeOffset.
        }}

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
            OrderDate = DateTimeOffset.Now();
        }

        public Order Retrieve(int Id)
        {
            return new Order();
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public bool Validate()
        {
            var isValid = true;
            if(OrderDate == null) isValid = false;
            return isValid;
        }

        public bool save(){
            return true;
        }
    }

}