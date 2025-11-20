public class Product  //Declaring attributes for our product in the class
{
    private string _name;
    private string _productId; 
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity) // Our product constructor
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()  // Method to calculate the total costs for our product considering the quantity
    {
        return _price * _quantity;
    }

    public string GetPackingInfo()  // Method to display packing information (Product name and ID)
    {
        return $"{_name} (ID: {_productId})";
    }
}
