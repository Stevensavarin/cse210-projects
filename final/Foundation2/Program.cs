using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("---------------------------------------------");
        //order 1 
        Address address1 = new Address ("La Bocaina.", "Calle Raul Leoni", "Apt 2", "Venezuela");
        Customer customer1 = new Customer("Pepito Perez", address1);

        double order1ShippingCost = customer1.GetShippingCost();

        Product order1Product1 = new Product("Laptop Lenovo 2024", "4131", 1200, 1);
        Product order1Product2 = new Product("Earphones Apple", "4225", 350, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        double order1Subtotal = order1.CalculateSubtotal();
        double order1Total = order1.CalculateTotal();

        //display order 1
        order1.DisplayShippingLabel(); 
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayCosts(order1Subtotal ,order1ShippingCost, order1Total);


        Console.WriteLine("---------------------------------------------");

        //order 2
        Address address2 = new Address ("Avenida Agustin Balsamo", "Cadiz", "Cadiz", "Spain");
        Customer customer2 = new Customer("Steven Savarin", address2);

        double order2ShippingCost = customer2.GetShippingCost();

        Product order2Product1 = new Product("Speaker JBL", "4260", 130, 1);
        Product order2Product2 = new Product("Guitar Fender", "4959", 1000, 1);
        Product order2Product3 = new Product("Mouse HP", "4029", 20, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        double order2Subtotal = order2.CalculateSubtotal();
        double order2Total = order2.CalculateTotal();


        //display order 2
        order2.DisplayShippingLabel(); 
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);
        Console.WriteLine("---------------------------------------------");

    }   
}