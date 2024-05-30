using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //This is going to be the principal Programm.
        void Running(Order order)
        {
            //This is going to be the same function to run the all objects in the future

            order.ShippingLabel();
            Console.WriteLine("-----------------------------");
            order.PackingLabel();

        }
        //Customers:----------------------------------------------------------------------
        Customer erick = new Customer();
        Customer eduardo = new Customer();

        //Setters for the customers
        erick.SetName("Erick");
        erick.SetAddress(new Address("3ra calle A 8-19", "San Miguel", "Guatemala", "Guatemala"));

        eduardo.SetName("Eduardo");
        eduardo.SetAddress(new Address("1 Av. 23D", "Lehi", "Salt Lake City", "USA"));

        Order order1 = new Order(erick);
        Order order2 = new Order(eduardo);

        //Adding items:---------------------------------------------------------------
        order1.AddProduct(new Product("Pencil", 1, 3.99, 20));
        order1.AddProduct(new Product("Eraser", 2, 0.99, 50));
        order1.AddProduct(new Product("T-shirt", 3, 15.99, 15));

        order2.AddProduct(new Product("Book", 4, 5.99, 20));
        order2.AddProduct(new Product("Pants", 5, 24.99, 8));
        order2.AddProduct(new Product("Keyboard", 6, 60.35, 2));


        Running(order1);
        Running(order2);


    }
}