using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Association_Composition
{
    internal class OrderItem
    {
        // OrderItem has an Item (Product) [Association Composition relationship]

        #region Properties
        public int Id { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        #endregion

        #region Constructor
        public OrderItem(Product _Product) 
        {
            Product = _Product; // Item يكون فيه OrderItem اساسي ان ال
        }
        #endregion

    }
}
