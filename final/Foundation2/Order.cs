using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    //Attributes-------------------------------------------------------------

    private List<Product> _products = new List<Product>();
    
    private Customer _customer = new Customer();

    //Constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    //Getters and Setters

    //Methods
    public double GetTotalCost()
    {
        //This method will return the total of the purchase
        double grossAmount = 0;
        int totalShipping;
        double netAmount;

        if (_customer.SeeCountryCustomer())
        {
            totalShipping = 5;
        }
        else
        {
            totalShipping = 30;
        }


        foreach (Product i in _products)
        {
            grossAmount =+ i.GetTotalCost();
        }

        netAmount = totalShipping + grossAmount;

        return netAmount;
    }

    public void PackingLabel()
    {
        //This methods will return the packing label
        Console.WriteLine("\nPacking Label: \n");
        for (int i = 0; i < _products.Count; i++)
        {
            Console.WriteLine($"Name: {_products[i].GetName()}");
            Console.WriteLine($"ID: {_products[i].GetId()}");
            Console.WriteLine($"Unit Price: {_products[i].GetPrice()}");
            Console.WriteLine($"Items: {_products[i].GetQuantity()}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Total: {_products[i].GetTotalCost()}");
            Console.WriteLine("-----------------------------------------\n\n");
        }

    }

    public void ShippingLabel()
    {
        //This method will print the shipping label
        Console.WriteLine("\nShipping Label");
        Console.WriteLine($"Client: {_customer.GetName()}");
        Console.WriteLine($"Address: {_customer.GetAddress()}");
    }

    public void AddProduct(Product newProduct)
    {
        //This methods works to add new products
        _products.Add(newProduct);
    }

}