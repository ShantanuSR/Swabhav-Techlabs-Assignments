using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDiscountApp.Model
{
    public class LineItem
    {
        private int _itemId;
        private int _quantity;
        public Product product;
        public LineItem(int itemId, int quantity,Product product)
        {
            _itemId = itemId;
            _quantity = quantity;
            this.product = product;

        }

        //Product inputProduct = new Product();


        public int ItemId
        {
            get { return _itemId; }
            set { _itemId = ItemId; }

        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = Quantity; }

        }

        public double CalculateLineItemCost()
        {
            double price = _quantity * product.CalculateDiscountedPrice();
            return price;
        }





    }

}
