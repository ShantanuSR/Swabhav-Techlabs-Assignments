using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.cs
{
    public class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private double _discountPercentage;

        

        public Product(int productId, string productName, double productPrice):this(productId, productName, productPrice, 0) 
        {
        }
        public Product(int productId, string productName, double productPrice, double discountPercent)
        {
            _id =productId ;
            _name = productName;
            _price = productPrice;
            _discountPercentage = discountPercent;
            
        }
        public static Product PrintDetails(Product[] products, int productId)
        {
            foreach (var product in products)
            {
                if (product._id == productId)
                {
                    return product;
                }
            }
            return null;
        }

        public static double DiscountAmount(Product[] products, int productId)
        {
            Product product = PrintDetails(products, productId);
            if (product != null)
            {
                double discountAmount = (product._discountPercentage / 100) * product._price;
                double priceAfterDiscount = product._price - discountAmount;
                return priceAfterDiscount;
            }
            return 0;
        }

        public override string ToString()
        {
            return "ProductId : " + _id + "\nProductname : " + _name + "\nProduct Price " + _price;
        }
    }

    
}
