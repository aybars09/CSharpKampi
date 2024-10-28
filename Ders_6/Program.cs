using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "Yeşil";
            //colors[1] = "Mor";
            //colors[2] = "Turuncu";
            //colors[3] = "Lacivert";

            //Console.WriteLine(colors[1]);

            //string[] cities = new string[5];

            //cities[0] = "Berlin";
            //cities[1] = "Amsterdam";
            //cities[2] = "Viyana";
            //cities[3] = "Seul";
            //cities[4] = "Tokyo";

            //Console.WriteLine(cities[3]);

            //int[] numbers = new int[10];

            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;
            //numbers[7] = 80;

            //Console.WriteLine(numbers[3]);

            //string[] cities = { "Londra", "Paris", "Lizbon", "Atina", "Kopenhag" };

            //Console.WriteLine(cities[1]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Kırmızı", "Mavi", "Siyah", "Beyaz", "Pembe", "Yeşil", "Gri" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 14, 65, 39, 74, 25, 458, 788, 165, 123, 999 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 5 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'x', 'y', 'z', '#', '$', '!' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] my_array = { 47, 25, 96, 78, 15, 152, 321, 98 };

            //int maxnumber = my_array[0];

            //for (int i = 0; i < my_array.Length; i++)
            //{
            //    if (my_array[i] > maxnumber)
            //    {
            //        maxnumber = my_array[i];
            //    }
            //}

            //Console.WriteLine(maxnumber);

            //string[] persons = { "can", "mehmet", "elif", "berk", "emre", "zeynep" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 5, 15, 30, 65, 80, 23, 75 };

            //Array.Sort(numbers);  // Küçükten Büyüğe sıralıyor

            //for (int i = 0; i < numbers.Length; i++) { 
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 3, 8, 45, 20, 67, 19, 55 };
            //Array.Reverse(numbers);  // Diziyi tersten tekrar yazıyor

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region Dizi Metodları

            //string[] customers = { "hasan", "melike", "ahmet", "burcu", "bora", "sibel" };
            //int index = Array.IndexOf(customers, "burcu"); // index numarasını buluyor

            //Console.WriteLine(index);

            //int[] numbers = { 45, 83, 99, 61, 72, 15, 20, 28, 38 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() 
            //    + " Dizinin en küçük elemanı: " +  numbers.Min());


            #endregion

            #region Kullanıcıdan Değer Alma

            string[] cities = new string[5];

            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
                cities[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("------------------------");

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }

            int[] numbers = { 5, 15, 25, 35, 45 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);

            int[] numbers2 = { 12, 35, 48, 59, 61, 72, 800, 521, 38, 200 };
            Console.WriteLine("Çift Sayılar");

            for (int i = 0; i < numbers2.Length; i++)
            {
                if (numbers2[i] % 2 == 0)
                {
                    Console.WriteLine(numbers2[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tek Sayılar");

            for (int i = 0; i < numbers2.Length; i++)
            {
                if (numbers2[i] % 2 == 1)
                {
                    Console.WriteLine(numbers2[i]);
                }
            }


            #endregion

            Console.Read();

        }
    }
}
