using System;
using System.Collections.Generic;
using acm.Interfaces;


namespace acm.BL
{

    public class Order : IEntity
    {
        private int _orderId;
        public DateTimeOffset? OrderDate { get; set; }

        public List<OrderItem> items;

        public int entityId
        {
            get 
            {
                return _orderId;
            }
            private set
            {
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
            items = new List<OrderItem>();
        }

        public static int instanceCounter
        {
            get;
            set;
        }

        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }

        public override string ToString()
        {
            var item = $"{orderId}: {OrderDate}";
            return item;
        }
    }

}