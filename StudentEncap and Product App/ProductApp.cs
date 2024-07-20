using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] product = new Product[]
            {                 
                new Product(1,"Jeans", 2000,6),
                new Product(2,"Trouser",800,5)
            };

            Console.WriteLine("Enter a product id");
            int productId = int.Parse(Console.ReadLine());

            Product selectedProduct = (Product.PrintDetails(product, productId));

            Console.WriteLine(selectedProduct);

            Console.WriteLine($"Final price after discount : " + Product.DiscountAmount(product, productId));

        }
    }
}
