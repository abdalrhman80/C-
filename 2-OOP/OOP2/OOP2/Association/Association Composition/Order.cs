using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Association_Composition
{
    internal class Order
    {
        // Order has a OrderItem [Association Composition relationship]

        #region Properties
        public int Id { get; set; }
        public string BuyerMail { get; set; }
        public decimal SubTotal { get; set; }
        public OrderItem[] Items { get; set; }
        #endregion

        #region Constructor
        public Order(string _BuyerMail, OrderItem[] _Items)
        {
            BuyerMail = _BuyerMail;
            Items = _Items; // OrderItem يكون فيه Order اساسي ان ال
        }
        #endregion
    }
}
