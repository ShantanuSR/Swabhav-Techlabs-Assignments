using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDiscountApp.Model
{
    public class Product
    {
        private int _productId;
        private string _productName;
        private double _productPrice;
        private double _discountPercent;

        public Product()
        {

        }
        public Product(int productId, string productName, double productPrice, double discountPercent)
        {
            _productId = productId;
            _productName = productName;
            _productPrice = productPrice;
            _discountPercent = discountPercent;
        }
        public int ProductId
        {
            get { return _productId; }
            set { _productId = ProductId; }

        }

        public string ProductName
        {
            get { return _productName; }
            set { _productName = ProductName; }
        }

        public double ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = ProductPrice; }
        }

        public double DiscountPercent
        {
            get { return _discountPercent; }
            set { _discountPercent = DiscountPercent; }
        }


        public double CalculateDiscountedPrice()
        {
            double discountPercent = _discountPercent / 100;

            double discountedPrice = _productPrice - _productPrice * discountPercent;

            return discountedPrice;
        }


    }
}
