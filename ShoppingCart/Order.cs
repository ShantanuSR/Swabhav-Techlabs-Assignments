using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDiscountApp.Model
{
    public class Order
    {
        private int _orderId;
        private DateTime _date;

       public List<LineItem> lineItems = new List<LineItem>();

        public Order()
        {

        }
        public Order(int orderId,DateTime date,List<LineItem> list)
        {
            _orderId = orderId;
            _date = date;
            this.lineItems = list;
        }

        public int OrderId
        {
            get { return _orderId; } 
            set { _orderId = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public double CalculateOrderPrice()
        { 
            double totalCost = 0;
            for(int i =0; i < lineItems.Count; i++)
            {
                totalCost = totalCost + lineItems[i].CalculateLineItemCost();
            }
           return totalCost;
        }
    }
}
