﻿using System.Collections.Concurrent;
using ProductDiscountApp.Model;
namespace ProductDiscountApp
{
    class Program
    {
        public static void Main(string[] args)
        {
           

            Product product1 = new Product(1,"Shirt",400,10);
            Product product2 = new Product(2,"Trouser",500,10);
            Product product3 = new Product(3,"T-Shirt",600,10);
            Product product4 = new Product(4,"Jeans",800,10);


            LineItem lineItem1 = new LineItem(1,5,product1);
            LineItem lineItem2 = new LineItem(2,5,product2);
            LineItem lineItem3 = new LineItem(3,5,product3);
            LineItem lineItem4 = new LineItem(4,5,product4);

            List<LineItem> list1 = new List<LineItem>(); 
            list1.Add(lineItem1);
            list1.Add(lineItem2);
            list1.Add(lineItem3);
            list1.Add(lineItem4);

            Order order1 = new Order(1,DateTime.Now,list1);
            //Order order2 = new Order(2,DateTime.Now,list2);
            Product product5 = new Product(1, "Samsung Fold", 150000, 5);
            Product product6 = new Product(2, "Washing Machine", 25000, 5);
            Product product7 = new Product(3, "Bluedart AC", 45000, 5);
            Product product8 = new Product(4, "Refridgerator ", 17000, 3);

            LineItem lineItem5 = new LineItem(1, 2, product5);
            LineItem lineItem6 = new LineItem(2, 1, product6);
            LineItem lineItem7 = new LineItem(3, 3, product7);
            LineItem lineItem8 = new LineItem(4, 1, product8);

            List<LineItem> list2 = new List<LineItem>();
            list2.Add(lineItem5);
            list2.Add(lineItem6);
            list2.Add(lineItem7);
            list2.Add(lineItem8);

            Order order2 = new Order(2, DateTime.Now, list2);

            List<Order> list3 = new List<Order>();
            list3.Add(order1);
            list3.Add(order2);

            Customer customer = new Customer(1, "Ram",list3);

            Product product = new Product();

            Console.WriteLine("Customer Id : " + customer.CustomerId + "\nCustomer name : "+customer.CustomerName+"\nOrder Count : "+list3.Count);

            foreach (Order order in list3)
            {
                Console.WriteLine("Order id is " + order.OrderId);
                Console.WriteLine("Order Date is " + order.Date);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"{"Line Item",-10}  |  {"Product Item",-10}  |  {"Product Name",-16} |  {"Quantity",-11} |  {"Unit Price",-10}  |  {"Discount",-11}  |  {"Cost after Discount",-20}  |  {"Total Line Item Cost",-20} |");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
                foreach (LineItem lineItem in order.lineItems)
                {
                    Console.WriteLine($"{lineItem.ItemId,-10}  |  {lineItem.product.ProductId,-12}  |  {lineItem.product.ProductName,-15}  |  {lineItem.Quantity,-10}  |  {lineItem.product.ProductPrice,-10}  |  {lineItem.product.DiscountPercent + " % ",-11}  |  {lineItem.product.CalculateDiscountedPrice(),-20}  |  {lineItem.CalculateLineItemCost(),-20} |");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
                }
                Console.WriteLine($"{"Sub Total",-10}  |  {"",-12}  |  {"",-16} |  {"",-11} |  {"",-10}  |  {"",-11}  |  {"",-20}  |  {order.CalculateOrderPrice(),-20} |");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

            //foreach(Order order in list3)
            //{
            //    Console.WriteLine("Order Id : "+ order.OrderId);
            //    Console.WriteLine();
            //    Console.WriteLine("Date : " + order.Date);

            //    foreach(LineItem l1 in order.lineItems)
            //    {
            //        Console.WriteLine("List Item id " + l1.ItemId);
            //        Console.WriteLine("List Item quantity " + l1.Quantity);
            //       Console.WriteLine("Actual price of product : "+ l1.product.ProductPrice);
            //        Console.WriteLine("List Item price " + l1.CalculateLineItemCost());
            //        Console.WriteLine();
            //    }

            //    Console.WriteLine("Total cost : " + order.CalculateOrderPrice());
            //    Console.WriteLine();

            //}





        }
    }
