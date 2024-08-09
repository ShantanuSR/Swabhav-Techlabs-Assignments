using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDiscountApp.Model
{
    public class Customer
    {
        private int _customerId;
        private string _customerName;

        List<Order> orders = new List<Order>();

        public Customer(int customerId,string customerName, List<Order> orders) 
        {
            _customerId = customerId;
            _customerName = customerName;
            this.orders = orders;
        }

        public int CustomerId 
        {
            get { return _customerId; } 
            set { _customerId = value; }
        }

        public string CustomerName
            { get { return _customerName; } set { _customerName = value; } }

    }
}
