using System;

namespace VariableOperationsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PriceCalculations - Meyve ve Sebzeler

            Console.WriteLine("==== Meyve ve Sebze Fiyat Listesi ====");
            double bananaPrice = 10.5;
            double grapePrice = 15.3;
            double mangoPrice = 30.75;
            double carrotPrice = 5.8;
            double cucumberPrice = 4.9;

            Console.WriteLine("1) Muz Fiyatı: " + bananaPrice + " TL");
            Console.WriteLine("2) Üzüm Fiyatı: " + grapePrice + " TL");
            Console.WriteLine("3) Mango Fiyatı: " + mangoPrice + " TL");
            Console.WriteLine("4) Havuç Fiyatı: " + carrotPrice + " TL");
            Console.WriteLine("5) Salatalık Fiyatı: " + cucumberPrice + " TL");
            Console.WriteLine("======================================\n");

            Console.WriteLine("Alınacak miktar bilgilerini giriniz:\n");

            Console.Write("Muz miktarı (kg): ");
            double bananaWeight;
            while (!double.TryParse(Console.ReadLine(), out bananaWeight))
            {
                Console.Write("Lütfen geçerli bir sayı girin: ");
            }

            Console.Write("Üzüm miktarı (kg): ");
            double grapeWeight;
            while (!double.TryParse(Console.ReadLine(), out grapeWeight))
            {
                Console.Write("Lütfen geçerli bir sayı girin: ");
            }

            Console.Write("Mango miktarı (kg): ");
            double mangoWeight;
            while (!double.TryParse(Console.ReadLine(), out mangoWeight))
            {
                Console.Write("Lütfen geçerli bir sayı girin: ");
            }

            Console.Write("Havuç miktarı (kg): ");
            double carrotWeight;
            while (!double.TryParse(Console.ReadLine(), out carrotWeight))
            {
                Console.Write("Lütfen geçerli bir sayı girin: ");
            }

            Console.Write("Salatalık miktarı (kg): ");
            double cucumberWeight;
            while (!double.TryParse(Console.ReadLine(), out cucumberWeight))
            {
                Console.Write("Lütfen geçerli bir sayı girin: ");
            }

            #endregion

            #region PriceCalculations - Elektronik ve Mobilya

            Console.WriteLine("\n==== Elektronik ve Mobilya Fiyat Listesi ====");
            double tvPrice = 5000;
            double laptopPrice = 10000;
            double chairPrice = 750;
            double deskPrice = 1200;

            Console.WriteLine("1) Televizyon Fiyatı: " + tvPrice + " TL");
            Console.WriteLine("2) Laptop Fiyatı: " + laptopPrice + " TL");
            Console.WriteLine("3) Sandalye Fiyatı: " + chairPrice + " TL");
            Console.WriteLine("4) Masa Fiyatı: " + deskPrice + " TL");
            Console.WriteLine("======================================\n");

            Console.Write("Televizyon adedi: ");
            int tvCount;
            while (!int.TryParse(Console.ReadLine(), out tvCount))
            {
                Console.Write("Lütfen geçerli bir sayı girin: ");
            }

            Console.Write("Laptop adedi: ");
            int laptopCount;
            while (!int.TryParse(Console.ReadLine(), out laptopCount))
            {
                Console.Write("Lütfen geçerli bir sayı girin: ");
            }

            Console.Write("Sandalye adedi: ");
            int chairCount;
            while (!int.TryParse(Console.ReadLine(), out chairCount))
            {
                Console.Write("Lütfen geçerli bir sayı girin: ");
            }

            Console.Write("Masa adedi: ");
            int deskCount;
            while (!int.TryParse(Console.ReadLine(), out deskCount))
            {
                Console.Write("Lütfen geçerli bir sayı girin: ");
            }

            #endregion

            #region Calculations - Meyve ve Sebzeler

            double totalBananaPrice = bananaPrice * bananaWeight;
            double totalGrapePrice = grapePrice * grapeWeight;
            double totalMangoPrice = mangoPrice * mangoWeight;
            double totalCarrotPrice = carrotPrice * carrotWeight;
            double totalCucumberPrice = cucumberPrice * cucumberWeight;

            double fruitAndVegTotalPrice = totalBananaPrice + totalGrapePrice + totalMangoPrice + totalCarrotPrice + totalCucumberPrice;

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("Muz Toplam Tutar: " + totalBananaPrice + " TL");
            Console.WriteLine("Üzüm Toplam Tutar: " + totalGrapePrice + " TL");
            Console.WriteLine("Mango Toplam Tutar: " + totalMangoPrice + " TL");
            Console.WriteLine("Havuç Toplam Tutar: " + totalCarrotPrice + " TL");
            Console.WriteLine("Salatalık Toplam Tutar: " + totalCucumberPrice + " TL");
            Console.WriteLine("\nMeyve ve Sebzeler Toplam Tutar: " + fruitAndVegTotalPrice + " TL");

            #endregion

            #region Calculations - Elektronik ve Mobilya

            double totalTvPrice = tvPrice * tvCount;
            double totalLaptopPrice = laptopPrice * laptopCount;
            double totalChairPrice = chairPrice * chairCount;
            double totalDeskPrice = deskPrice * deskCount;

            double electronicsAndFurnitureTotalPrice = totalTvPrice + totalLaptopPrice + totalChairPrice + totalDeskPrice;

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("Televizyon Toplam Tutar: " + totalTvPrice + " TL");
            Console.WriteLine("Laptop Toplam Tutar: " + totalLaptopPrice + " TL");
            Console.WriteLine("Sandalye Toplam Tutar: " + totalChairPrice + " TL");
            Console.WriteLine("Masa Toplam Tutar: " + totalDeskPrice + " TL");
            Console.WriteLine("\nElektronik ve Mobilya Toplam Tutar: " + electronicsAndFurnitureTotalPrice + " TL");

            #endregion

            #region Total Calculation

            double shoppingTotalPrice = fruitAndVegTotalPrice + electronicsAndFurnitureTotalPrice;
            Console.WriteLine("\nAlışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");

            #endregion

            Console.WriteLine("\nProgramı kapatmak için bir tuşa basın...");
            Console.ReadLine();
        }
    }
}
