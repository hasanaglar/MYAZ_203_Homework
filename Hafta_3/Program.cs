using Hafta_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var product = new Product() { ProductId = 1, ProductName = "Iphone 11", ProductPrice = 16_499};
            var product1 = new Product() { ProductId = 2, ProductName = "Iphone 13", ProductPrice = 25_399};
            var product2 = new Product() { ProductId = 3, ProductName = "Iphone 14", ProductPrice = 30_999};
            var product3 = new Product() { ProductId = 4, ProductName = "Iphone 14 PRO", ProductPrice = 42_180};

            var cartItem = new CartItem() { CartId = 1, Product = product, Quantity = 4 };
            var cartItem2 = new CartItem() { CartId = 2, Product = product1, Quantity = 6 };
            var cartItem3 = new CartItem() { CartId = 3, Product = product2, Quantity = 3 };
            var cartItem4 = new CartItem() { CartId = 4, Product = product3, Quantity = 2 };

            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(cartItem);
            shoppingCart.Add(cartItem2);
            shoppingCart.Add(cartItem3);
            shoppingCart.Add(cartItem4);

            shoppingCart.Remove(0);

            shoppingCart.GetList();

            Console.WriteLine(shoppingCart.GetBalance());

            Console.ReadLine();
        }
    }
}