public class Customer
{
    //Attributes
    private string _name;
    private Address _address;

    //Contructor

    // public Customer(string name, Address address)
    // {
    //     _name = name;
    //     _address = address;
    // }

    //Getters and Setters
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public string GetAddress()
    {
        return _address.GetFullAddress();
    }

    //Methods

    public bool SeeCountryCustomer()
    {
        //This methods will return if the customer is living in USA or not
        //Using the method from Adress Class

        return _address.IsUSA();
    }




}