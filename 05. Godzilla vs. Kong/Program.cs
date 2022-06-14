using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double sale = 0;
            double filmBudget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double pricePerExtras = double.Parse(Console.ReadLine());

            double decorPrice = filmBudget * 0.10;
            double totalPriceForExtras = extras * pricePerExtras;
            if(extras>150)
            {
                 sale =  totalPriceForExtras * 0.10;
            }
            double totalPrice = totalPriceForExtras-sale + decorPrice;
            double difference = Math.Abs(totalPrice - filmBudget);
            if (totalPrice> filmBudget)
            {
                Console.WriteLine(	"Not enough money!");
                Console.WriteLine($"Wingard needs {difference:F2} leva more.");

            }
           else if (totalPrice<=filmBudget)
            {
                Console.WriteLine(	"Action!");
                Console.WriteLine($"Wingard starts filming with {difference:F2} leva left.");

            }

        }
    }
}
