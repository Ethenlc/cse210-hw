public class Product
{
    public string _name;
    public int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double CalculateProductPrice()
    {
        return _price * _quantity;
    }

    public string Name => _name;
    
    public int ProductId => _productId;
}