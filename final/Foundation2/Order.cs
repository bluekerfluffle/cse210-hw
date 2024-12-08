using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer {get; set;}

    public Order (Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalcSubtotal() 
    {
        double subtotal = 0;
        foreach (Product product in _products)
        {
            double productPrice = product.CalculatePrice();
            subtotal += productPrice;
        }
        subtotal = Math.Round(subtotal, 2);
        return subtotal;
    }

    public double CalcTotal()
    {
        double total = Math.Round((CalcSubtotal() + _customer.GetShippingCost()),2);
        return total;
    }

    public void DisplayCost(double subtotal, double shippingCost, double totalCost)
    {   
        Console.WriteLine($"Subtotal: ${subtotal}");
        Console.WriteLine($"Shipping: ${shippingCost}");
        Console.WriteLine($"Total: ${totalCost}");
    }

    public void DisplayPackingLabel()
    {   
        Console.WriteLine("Packing Label");
        foreach (Product product in _products)
        {
            product.DisplayProductDetails();
        }
        
    }
    public void DisplayShippingLabel()
    {   
        Console.WriteLine("Shipping Label");
        Console.WriteLine("SHIP TO: ");
        _customer.DisplayCustomer();
    }

    
}