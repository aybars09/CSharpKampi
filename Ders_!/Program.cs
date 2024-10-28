using System;

namespace RestaurantOrderSummary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MenuDisplay

            Console.WriteLine("==== Restoran Yemek Fiyat Listesi ====");
            Console.WriteLine("1) Tavuk Burger: 250 TL");
            Console.WriteLine("2) Vejetaryen Pizza: 220 TL");
            Console.WriteLine("3) Gazoz: 25 TL");
            Console.WriteLine("4) Şeftali Suyu: 20 TL");
            Console.WriteLine("5) Patates Cipsi: 40 TL");
            Console.WriteLine("6) Soda: 8 TL");
            Console.WriteLine("======================================\n");

            #endregion

            #region OrderDetails

            int chickenBurgerPrice = 250;
            int vegPizzaPrice = 220;
            int sodaPrice = 25;
            int peachJuicePrice = 20;
            int chipsPrice = 40;
            int sparklingWaterPrice = 8;

            Console.WriteLine("Lütfen siparişlerinizi belirtin:\n");

            Console.Write("Tavuk Burger adedi: ");
            int chickenBurgerCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vejetaryen Pizza adedi: ");
            int vegPizzaCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gazoz adedi: ");
            int sodaCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Şeftali Suyu adedi: ");
            int peachJuiceCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Patates Cipsi adedi: ");
            int chipsCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Soda adedi: ");
            int sparklingWaterCount = Convert.ToInt32(Console.ReadLine());

            #endregion

            #region Calculations

            int totalChickenBurgerPrice = chickenBurgerCount * chickenBurgerPrice;
            int totalVegPizzaPrice = vegPizzaCount * vegPizzaPrice;
            int totalSodaPrice = sodaCount * sodaPrice;
            int totalPeachJuicePrice = peachJuiceCount * peachJuicePrice;
            int totalChipsPrice = chipsCount * chipsPrice;
            int totalSparklingWaterPrice = sparklingWaterCount * sparklingWaterPrice;

            int totalPrice = totalChickenBurgerPrice + totalVegPizzaPrice + totalSodaPrice + totalPeachJuicePrice + totalChipsPrice + totalSparklingWaterPrice;

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("Tavuk Burger Tutarı: " + totalChickenBurgerPrice + " TL");
            Console.WriteLine("Vejetaryen Pizza Tutarı: " + totalVegPizzaPrice + " TL");
            Console.WriteLine("Gazoz Tutarı: " + totalSodaPrice + " TL");
            Console.WriteLine("Şeftali Suyu Tutarı: " + totalPeachJuicePrice + " TL");
            Console.WriteLine("Patates Cipsi Tutarı: " + totalChipsPrice + " TL");
            Console.WriteLine("Soda Tutarı: " + totalSparklingWaterPrice + " TL");

            Console.WriteLine("\nToplam Ödenecek Tutar: " + totalPrice + " TL");

            #endregion

            Console.WriteLine("\nProgramı kapatmak için bir tuşa basın...");
            Console.ReadLine();
        }
    }
}
