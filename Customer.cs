namespace ACM.BL;
public class Customer
{

    public int CustomerId {
        get;
        private set;
    }

    private string _FirstName;
    private string _LastName;

    public string FirstName {
        get {
            return _FirstName;
        }

        set {
            _FirstName = value;
        }
    }

    public string LastName {
        get {
            return _LastName;
        }

        set {
            _LastName = value;
        }
    }

    public string FullName {
        get{
            return $"{FirstName},{LastName}";
        }
    }
    public string EmailAddress {
        get;
        private set;
    }

    public string Address {
        get;
        private set;
    }

    public string Phonenumber{
        get;
        private set ;
    }
}
