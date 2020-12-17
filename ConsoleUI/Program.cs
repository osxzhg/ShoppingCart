using LibraryForShoppingCart;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static ShoppingCartModel cart = new ShoppingCartModel();
        static void Main(string[] args)
        {
            PopulateCartWithDemoData();

            Console.WriteLine($"The total for the cart is {cart.GenerateTotal(SubTotalAlert, CalculateLeveledDiscount,AlertUser):C2}");

            Console.WriteLine();

            Console.WriteLine("Please press any key");

            Console.ReadLine();
        }

        private static void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }

        private static void SubTotalAlert(decimal subTotal)
        {
            Console.WriteLine($"The subtotal is {subTotal:C2}");
        }

        private static decimal CalculateLeveledDiscount(List<ProductModel> items, decimal subTotal)
        {
            if(subTotal > 100)
            {
                return subTotal * 0.80M;
            }
            else if (subTotal >50)
            {
                return subTotal * 0.85M;
            }
            else
            {
                return subTotal * 0.9M;
            }
        }

        private static void AlertUser(string message)
        {
            Console.WriteLine(message);
        }
    }
}
