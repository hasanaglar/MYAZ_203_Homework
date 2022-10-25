using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_3
{
    public class CartItem
    {
        public int CartId { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"CartID:{CartId,-5}" +
                $"Product:{Product?.ProductName,-10}" +
                $"Quantity:{Quantity,5}";
        }
    }
}
