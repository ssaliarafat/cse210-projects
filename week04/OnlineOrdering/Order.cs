public class Order     // The attributes include the customer object and a list to store our products
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)  // The constructor
    {
        _customer = customer;
    }

    public void AddProduct(Product product) // Adding products to the list
    {
        _products.Add(product);
    }

    public double GetTotalPrice()  // Calculating the total price for all products
    {
        double total = 0;

        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

       double shipping;   // Checking a customer who both lives and doesn't live in USA to the shipping cost
        if (_customer.LivesInUSA())
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }

        return total + shipping;
    }

    public string GetPackingLabel() // Displaying the Packing Label from the product class's GetPackingInfo method
    {
        string label = "PACKING LABEL:\n";
        foreach (Product p in _products)
        {
            label += "- " + p.GetPackingInfo() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()  // Displaying the Shipping label from the customer class's GetName and GetAddressString methods
    {
        return $"SHIPPING LABEL:\n{_customer.GetName()}\n{_customer.GetAddressString()}";
    }
}
