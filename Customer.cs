using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acm.BL
{
    
    public class Customer : IEntity
    {

        public int entityId
        {
            get;
            private set;
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

        public Address homeAddress
        {
            get;
            private set;
        }

        public Address workAddress
        {
            get;
            private set;
        }
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
