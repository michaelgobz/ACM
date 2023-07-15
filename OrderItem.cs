using System;
using System.Collections.Generic;

namespace acm.BL
{
    public class OrderItem
    {

        private int _orderItemId;
        public int productId { get; set; }
        public int Quantity { get; set; }

        public decimal? PurchasePrice { get; set; }

        public int orderItemId
        {
            get;

            private set
            {
                _orderItemId = value;
            }
        }

        public OrderItem()
        {

        }

        public OrderItem(int Id)
        {
            orderItemId = Id;
        }

        public bool Validate()
        {
            var isValid = true;
            if (PurchasePrice == null) isValid = false;
            if (int.IsNegative(PurchasePrice) && PurchasePrice == null)
                isValid = false;

            return isValid;
        }

        public OrderItem Retrieve(int Id)
        {
            return new OrderItem();
        }

        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        public bool save()
        {
            return true;
        }


    }
}