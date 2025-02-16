using System.Reflection.Metadata.Ecma335;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalPrice()
    {
        double totalPrice = 0;

        foreach (Product product in _products)
        {
            totalPrice += product.TotalCost();
        }

        if (_customer.CustomerInUSA())
        {
            return totalPrice + 5;
        }

        else
        {
            return totalPrice + 35;
        }
    }

    public string PackagingLabel()
    {
        string label = "Packaging Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetProduct()}\n";
        }

        return label;
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetCustomer()}";
    }
}
