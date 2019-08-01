using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForAssignment
{
    class interfaceClass
    {
        // I have various Product
        // I have gift cards 
        // I can buy product & gift cards in site by adding them in shopping cart
        // I have 3 catagory products , Electronis, books, stationaries.

        public void interfaceFunction()
        {
            var cart = new ShoppingCart();
            for (int i = 0; i < cart.Items.Length; i++)
            {
                Console.WriteLine(cart.Items[i].GetVat());
            }
        }

    }

    interface IItem
    {
        double GetVat();

    }


    abstract class  Item
    {
         public string ImageUrl; //jokhn interface use korbo
         public double price; //jokhn interface use korbo
        public double calculateDollarPrice()
        {
            return price / 80;

        }
        public abstract double GetVat();
        

        
    }
    class Product : Item
    {
        // public string Name; //jokhn interface use korbo

            
        public override double GetVat()
        {
            return price * 15 / 100;
        }

       
    
    }
    class Giftcard : Item
    {
        public string ReceiverEmailAddress;
        public override double GetVat()
        {
            return 0;

        }

    }

    class ShoppingCart 
    {
        public Item[] Items; 

    }
}
