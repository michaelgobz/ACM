﻿using acm.BL;
namespace acm.BL
{
    
    public class Customer : IEntity, IEntityWithAddresses
    {
		private int _customerId;

        public int entityId
        {
            get {
				return _customerId;
			}
            private set {
				_customerId = value;
			}
        }

        private string _FirstName;
        private string _LastName;

        public string FirstName
        {
            get
            {
                return _FirstName;
            }

            set
            {
                _FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _LastName;
            }

            set
            {
                _LastName = value;
            }
        }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }

                return fullName;
            }
        }
        public string EmailAddress
        {
            get;
            set;
        }

		public Repository<Address> addresses {get; set;}
        public string Phonenumber
        {
            get;
            private set;
        }

        public static int instanceCounter
        {
            get;
            set;
        }

		public Customer() :this(0)
		{

		}

		public Customer(int id){
			entityId = id;
			addresses = new Repository<Address>(id);
		}

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            var item = $"{CustomerId}: {FullName}: {EmailAddress}";
            return item;
        }
    }

}
