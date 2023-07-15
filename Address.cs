using System;
using System.Collections.Generic;
using acm.Interfaces;

namespace acm.BL
{

    public class Address : IEntity
    {
        private int _addressId;
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public int PostalCode {get; set;}
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

        public int entityId { get { return _addressId;} set { _addressId = value;} }

        public Address(){

        }

        public Address(int id){
            addressId = id;
        }

        public static int instanceCounter
        {
            get;
            set;
        }


        public bool Validate(){
            bool isValid =  true;
            if(City == null && Country == null) isValid = false;
            return isValid;
        }

        public override string ToString()
        {
            var address = $"{entityId}:{Country}:{City}:{State}:{PostalCode}";
            return address;
        }


    }

}