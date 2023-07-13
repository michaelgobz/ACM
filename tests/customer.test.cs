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
}