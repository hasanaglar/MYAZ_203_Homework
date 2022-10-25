using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_3
{
    public class ShoppingCart
    {
        private List<CartItem> _cartList;

        public ShoppingCart()
        {
            _cartList = new List<CartItem>();
        }

        public void Add(CartItem item)
        {
            _cartList.Add(item);
        }

        public CartItem ReadCartItem(int id)
        {
            return _cartList[id];
        }

        public CartItem Remove(int id)
        {
            var std = ReadCartItem(id);
            _cartList.RemoveAt(id);
            return std;
        }

        public void GetList()
        {
            foreach (var item in _cartList)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public string GetBalance()
        {
            float price = 0;
            foreach (var item in _cartList)
            {
                price += item.Product.ProductPrice * item.Quantity;
            }
            return ($"Toplam: {price}");
        }
    }
}
