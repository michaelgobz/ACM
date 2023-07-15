using acm.BL;
namespace tests.data 
{
    // address

    var address1 = new Address(1)
    {
        City= "kampala",
        Country= "Uganda",
        State= "CBD",
        PostalCode = 256,
        StreetLine1 = "7th Street Bank Avenue",
        StreetLine2 = "6th Street EDB clause"
    };

    var address2 = new Address(2)
    {
        City= "wakiso",
        Country= "Uganda",
        State= "Bulaga",
        PostalCode = 256,
        StreetLine1 = "Mwenda street",
        StreetLine2 = "Market Street"
    };

    var address3 = new Address(3)
    {
        City= "Jinja",
        Country= "Uganda",
        State= "Centre",
        PostalCode = 256,
        StreetLine1 = "City Headquaters",
        StreetLine2 = "Nile Bridge Straight"
    };

    var address4 = new Address(4)
    {
        City= "Masaka",
        Country= "Uganda",
        State= "Saaza Buddu",
        PostalCode = 256,
        StreetLine1 = "Market",
        StreetLine2 = "9th street industrial Area"
    };

    var address5 = new Address(5)
    {
        City= "kampala",
        Country= "Uganda",
        State= "CBD",
        PostalCode = 256,
        StreetLine1 = "5th Street Bank Avenue",
        StreetLine2 = "8th Zebra Plaza"
    };

    var address6 = new Address(6)
    {
        City= "kampala",
        Country= "Uganda",
        State= "CBD",
        PostalCode = 256,
        StreetLine1 = "Entebbe Road",
        StreetLine2 = "Dustur Street"
    };

    var address7 = new Address(7)
    {
        City= "kampala",
        Country= "Uganda",
        State= "CBD",
        PostalCode = 256,
        StreetLine1 = "5th street industrial area",
        StreetLine2 = "8th Street"
    };

    // Customers

    var customer1 = new Customer(1) 
    {
        FirstName = "Michael",
        LastName = "Goboola",
        Phonenumber = "+256758591449",
        EmailAddress = "raniahgobz@outlook.com",

    };

    var customer2 = new Customer(2) 
    {
        FirstName = "Nicole",
        LastName = "Nafula",
        Phonenumber = "+256758256449",
        EmailAddress = "nicole.nafula@outlook.com",
    
    };

    var customer3 = new Customer(3) 
    {
        FirstName = "Ayebare",
        LastName = "Moureen",
        Phonenumber = "+256759041449",
        EmailAddress = "ayebare.moureen@outlook.com",
    
    };

    var customer4 = new Customer(4) 
    {
        FirstName = "Namugalu",
        LastName = "Lynn",
        Phonenumber = "+256758976449",
        EmailAddress = "namugalu.lynn@outlook.com",
        
    };

    var customer5 = new Customer(5) 
    {
        FirstName = "Atuhaire",
        LastName = "Mbaaga",
        Phonenumber = "+256762860919",
        EmailAddress = "atuhaire.mbaaga@outlook.com",
     
    };

    var customer6 = new Customer(6) 
    {
        FirstName = "Nicole",
        LastName = "Nina",
        Phonenumber = "+256758591449",
        EmailAddress = "nicole.nina@outlook.com",
 
    };

    // products

    var product1 = new Product(1)
    {
        productName = "Google Pixel 1",
        productDescription = "Google Pixel 1 is the first smartphone released by google that runs on android",
        currentPrice = 500
    };

    var product2 = new Product(2)
    {
        productName = "Google Pixel 7",
        productDescription = "Google Pixel 7 is the Latest smartphone released by google that runs on android",
        currentPrice = 1500
    };

    var product3 = new Product(3)
    {
        productName = "Mac M1",
        productDescription = "Mac M1 is a laptop released by apple that runs on IOS on the new M1 chip",
        currentPrice = 2500
    };

    var product4 = new Product(4)
    {
        productName = "Red Velvet Cake",
        productDescription = "Red sweet Velvet cake with chocolate sprinkles",
        currentPrice = 50
    };

    var product5 = new Product(5)
    {
        productName = "Ear Pods Pro",
        productDescription = "The Pods pro are the upgraded version of the ear pods which brings the best of every feature",
        currentPrice = 500
    };

    var product6 = new Product(6)
    {
        productName = "Gucci Bag Pro",
        productDescription = "Luxurious Gucci branded bag with lather and matt finish",
        currentPrice = 600
    };

    var product7 = new Product(7)
    {
        productName = "Vanilla Milk Sheck",
        productDescription = "Milk Sheck flavoured with the vanilla taste from vanilla african grains",
        currentPrice = 30
    };

    // order items
    var item1 = new OrderItem(1)
    {
        productId = 1,
        Quantity= 2,
        PurchasePrice = 1000
    };

    var item2 = new OrderItem(2)
    {
        productId = 1,
        Quantity= 4,
        PurchasePrice = 2000
    };

    var item3 = new OrderItem(3)
    {
        productId = 2,
        Quantity= 2,
        PurchasePrice = 5000
    };

    var item4 = new OrderItem(4)
    {
        productId = 4,
        Quantity= 20,
        PurchasePrice = 1000
    };

    var item5 = new OrderItem(5)
    {
        productId = 3,
        Quantity= 2,
        PurchasePrice = 3000
    };

    var item6 = new OrderItem(6)
    {
        productId = 7,
        Quantity= 10,
        PurchasePrice = 300
    };

    var item7 = new OrderItem(7)
    {
        productId = 3,
        Quantity= 2,
        PurchasePrice = 3000
    };

    var item8 = new OrderItem(8)
    {
        productId = 6,
        Quantity= 4,
        PurchasePrice = 2400
    };

    var item9 = new OrderItem(9)
    {
        productId = 1,
        Quantity= 10,
        PurchasePrice = 5000
    };

    var item10 = new OrderItem(10)
    {
        productId = 5,
        Quantity= 3,
        PurchasePrice = 4000
    };

    var item11 = new OrderItem(11)
    {
        productId = 7,
        Quantity= 12,
        PurchasePrice = 360
    };

    // orders

     var order1 = new Order(1) 
     {
        items = {item1, item2}  
     };
     var order2 = new Order(2)
     {
        items = {item11, item2}
     };
     var order3 = new Order(3)
     {
        items = {item10, item2}
     };
     var order4 = new Order(4)
     {
        items = {item3, item2, item6}

     };
     var order5 = new Order(5)
     {
        items = {item9, item7, item5, item8}
     };
     var order6 = new Order(6)
     {
        items = {item3, item4, item9, item6}

     };
     var order7 = new Order(7)
     {
        items = {item10, item11}

     };

}