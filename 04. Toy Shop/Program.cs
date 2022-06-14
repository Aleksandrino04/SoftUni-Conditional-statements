using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzelQuantity = int.Parse(Console.ReadLine());
            int dollQuantity = int.Parse(Console.ReadLine());
            int bearQuantity = int.Parse(Console.ReadLine());
            int minionQuantity = int.Parse(Console.ReadLine());
            int truckQuantity = int.Parse(Console.ReadLine());

            int totalQuantity = puzzelQuantity + dollQuantity + bearQuantity + minionQuantity + truckQuantity;
            double totalPrice = (puzzelQuantity*2.60) + (dollQuantity*3) + (bearQuantity*4.10) + (minionQuantity*8.20) + (truckQuantity*2);

            if (totalQuantity>=100)
            {
                totalPrice = totalPrice - (totalPrice * 0.25);
            }
            totalPrice = totalPrice - totalPrice * 0.10;
            if(totalPrice>=tripPrice)
            {
                Console.WriteLine($"Yes! {totalPrice-tripPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice-totalPrice:F2} lv needed.");
            }



        }
        
    }
}
