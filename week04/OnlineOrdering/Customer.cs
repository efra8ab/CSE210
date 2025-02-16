using System.Reflection;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool CustomerInUSA()
    {
        return _address.InTheUSA();
    }

    public string GetCustomer()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}