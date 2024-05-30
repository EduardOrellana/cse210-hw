public class Product
{
    //Attributes
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;


    //Constructor
    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _quantity = quantity;
        _price = price;
    }

    //Getters and Setters
    public string GetName()
    {
        return _name;
    }

    public int GetId()
    {
        return _id;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetId(int id)
    {
        _id = id;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public void SetPrice(int price)
    {
        _price = price;
    }

    //Methods

    public double GetTotalCost()
    {
        return _quantity * _price;
    }


}