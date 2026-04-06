public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }
    public void SetProducts(List<Product> products)
    {
        _products = products;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public double TotalPrice()
    {
        double totalPrice = 0.00;
        Address address = _customer.GetAddress();

        foreach (Product product in _products)
        {
            totalPrice = totalPrice + product.TotalPrice();
        }

        if (address.IsUSA() == true)
        {
            totalPrice = totalPrice + 5;
        }
        else
        {
            totalPrice = totalPrice + 35;
        }

        return totalPrice;
    }
    public string PackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label = label + $"\n{product.GetName()} - {product.GetID()} ({product.GetQuantity()})";
        }

        return label;
    }
    public string ShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetFormatedAddress()}";
    }
}