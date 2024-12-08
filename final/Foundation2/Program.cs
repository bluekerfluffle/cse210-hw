using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("---------------------------------------------");
        //order 1 
        Address address1 = new Address ("2708 Nephi Ave.", "Dallas", "TX", "USA");
        Customer customer1 = new Customer("Ben Franklin", address1);

        double order1ShippingCost = customer1.GetShippingCost();

        Product order1Product1 = new Product("Organic Banana", "4040", 0.25, 8);
        Product order1Product2 = new Product("Hamburger", "3085", 5.25, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        double order1Subtotal = order1.CalcSubtotal();
        double order1Total = order1.CalcTotal();

        //display order 1
        order1.DisplayShippingLabel(); 
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayCost(order1Subtotal ,order1ShippingCost, order1Total);


        Console.WriteLine("---------------------------------------------");


        //order 2
        Address address2 = new Address ("99 Alma Dr", "Salt Lake City", "UT", "USA");
        Customer customer2 = new Customer("John Henry", address2);

        double order2ShippingCost = customer2.GetShippingCost();

        Product order2Product1 = new Product("Taco Shells", "3958", 3.00, 4);
        Product order2Product2 = new Product("Shredded Cheddar Cheese", "4560", 4.00, 1);
        Product order2Product3 = new Product("Chicken", "4529", 14.00, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        double order2Subtotal = order2.CalcSubtotal();
        double order2Total = order2.CalcTotal();


        //display order 2
        order2.DisplayShippingLabel(); 
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayCost(order2Subtotal, order2ShippingCost, order2Total);
        Console.WriteLine("---------------------------------------------");

    }   
}