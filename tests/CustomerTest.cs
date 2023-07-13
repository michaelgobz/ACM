using ACM.BL;
namespace ACM.tests;

[TestClass]
public class CustomerTest
{
    [TestMethod]
    public void TestFullNameIsValid()
    {

        // Arrange
        var customer = new Customer
        {
            FirstName = "Michael",
            LastName = "Goboola"
        };
    
        // Act
        var expected = "Michael, Goboola";

        // Assert
        Assert.AreEqual(expected, customer.FullName);
    }

    public void TestFirstNameIsValid()
    {

        // Arrange
        var customer = new Customer
        {
            LastName = "Goboola"
        };
    
        // Act
        var expected = "Goboola";

        // Assert
        Assert.AreEqual(expected, customer.FullName);
    }

    public void TestLastNameIsValid()
    {

        // Arrange
        var customer = new Customer
        {
            FirstName = "Michael",
        };
    
        // Act
        var expected = "Michael, ";

        // Assert
        Assert.AreEqual(expected, customer.FullName);
    }

    public void StaticTest()
    {

        // Arrange
        var c1 = new Customer
        {
            FirstName = "Michael",
            LastName = "Goboola"
        };
        Customer.instanceCounter += 1;

        var c2 = new Customer
        {
            FirstName = "Moureen",
            LastName = "Nafula"
        };
        Customer.instanceCounter += 1;

        var c3 = new Customer
        {
            FirstName = "Agaba",
            LastName = "Atuhaire"
        };
        Customer.instanceCounter += 1;

        var c4 = new Customer
        {
            FirstName = "Prudence",
            LastName = "Nuwagaba"
        };
        Customer.instanceCounter += 1;
    
        // Act
        var count= 4;
        // Assert
        Assert.Equal(count, customer.instanceCounter);
    }

    public void ValidateCustomer()
    {

        // Arrange
        var customer = new Customer
        {
            FirstName = "Michael",
            LastName = "Goboola"
        };

        var expected = true;
    
        // Act
        var actual = customer.Validate();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    public void ValidateCustomerHasOneName()
    {

        // Arrange
        var customer = new Customer
        {
            EmailAddress = "raniahgobz@outlook.com"
        };

        var expected = false;
    
        // Act
        var actual = customer.Validate();

        // Assert
        Assert.AreEqual(expected, actual);
    }
}