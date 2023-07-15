using System;
using System.Collections.Generic;
using acm.Interfaces;

namespace acm.BL
{
    public class OrderItem : IEntity
    {

        private int _orderItemId;
        public int productId { get; set; }
        public int Quantity { get; set; }

        public decimal? PurchasePrice { get; set; }

        public int entityId
        {
            get 
            {
                return _orderItemId;
            }

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

        public static int instanceCounter
        {
            get;
            set;
        }

        public bool Validate()
        {
            var isValid = true;
            if (PurchasePrice == null) isValid = false;
            if (int.IsNegative(PurchasePrice) && PurchasePrice == null)
                isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            var item = $"{entityId}: {productId}: {Quantity}: {PurchasePrice}";
            return item;
        }


    }
}