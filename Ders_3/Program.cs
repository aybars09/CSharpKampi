using System;

namespace DecisionMakingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PasswordCheck

            Console.Write("Lütfen şifreyi giriniz: ");
            string password = Console.ReadLine();
            if (password == "1234")
            {
                Console.WriteLine("Şifre Doğru");
            }
            else
            {
                Console.WriteLine("Şifre Yanlış");
            }

            #endregion

            #region AverageGradeEvaluation

            Console.Write("Sınav 1: ");
            int exam1;
            while (!int.TryParse(Console.ReadLine(), out exam1))
            {
                Console.Write("Lütfen geçerli bir sayı girin: ");
            }

            Console.Write("Sınav 2: ");
            int exam2;
            while (!int.TryParse(Console.ReadLine(), out exam2))
            {
                Console.Write("Lütfen geçerli bir sayı girin: ");
            }

            Console.Write("Sınav 3: ");
            int exam3;
            while (!int.TryParse(Console.ReadLine(), out exam3))
            {
                Console.Write("Lütfen geçerli bir sayı girin: ");
            }

            int average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Sınavların Ortalaması: " + average);

            if (average >= 85)
            {
                Console.WriteLine("Sonuç: Çok İyi");
            }
            else if (average >= 70)
            {
                Console.WriteLine("Sonuç: İyi");
            }
            else if (average >= 50)
            {
                Console.WriteLine("Sonuç: Orta");
            }
            else
            {
                Console.WriteLine("Sonuç: Vasat");
            }

            #endregion

            #region ModulusCheck

            Console.Write("Bir sayı giriniz: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Lütfen geçerli bir sayı girin: ");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("Sayı Çifttir");
            }
            else
            {
                Console.WriteLine("Sayı Tektir");
            }

            #endregion

            #region MenuSelection

            Console.WriteLine("\n*** Restoran Menü Seçimi ***");
            Console.WriteLine("1 - Ana Yemekler");
            Console.WriteLine("2 - Çorbalar");
            Console.WriteLine("3 - Tatlılar");

            Console.Write("Menü numarasını giriniz: ");
            string menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    Console.WriteLine("\nAna Yemekler: Izgara Tavuk, Et Sote, Sebzeli Makarna");
                    break;
                case "2":
                    Console.WriteLine("\nÇorbalar: Mercimek, Tarhana, Tavuk Suyu");
                    break;
                case "3":
                    Console.WriteLine("\nTatlılar: Baklava, Sütlaç, Kazandibi");
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim yaptınız.");
                    break;
            }

            #endregion

            #region SwitchCaseMonth

            Console.Write("\nLütfen Ay Numarasını Giriniz (1-12): ");
            int monthNumber;
            while (!int.TryParse(Console.ReadLine(), out monthNumber) || monthNumber < 1 || monthNumber > 12)
            {
                Console.Write("Lütfen 1-12 arasında geçerli bir ay numarası girin: ");
            }

            switch (monthNumber)
            {
                case 1: Console.WriteLine("Ocak"); break;
                case 2: Console.WriteLine("Şubat"); break;
                case 3: Console.WriteLine("Mart"); break;
                case 4: Console.WriteLine("Nisan"); break;
                case 5: Console.WriteLine("Mayıs"); break;
                case 6: Console.WriteLine("Haziran"); break;
                case 7: Console.WriteLine("Temmuz"); break;
                case 8: Console.WriteLine("Ağustos"); break;
                case 9: Console.WriteLine("Eylül"); break;
                case 10: Console.WriteLine("Ekim"); break;
                case 11: Console.WriteLine("Kasım"); break;
                case 12: Console.WriteLine("Aralık"); break;
                default: Console.WriteLine("Geçersiz Ay"); break;
            }

            #endregion

            #region Char Decision Making

            Console.Write("\nLütfen bir takım sembolü giriniz (G/F/B): ");
            char team;
            while (!char.TryParse(Console.ReadLine(), out team))
            {
                Console.Write("Lütfen geçerli bir karakter girin: ");
            }

            switch (char.ToUpper(team))
            {
                case 'G':
                    Console.WriteLine("Galatasaray");
                    break;
                case 'F':
                    Console.WriteLine("Fenerbahçe");
                    break;
                case 'B':
                    Console.WriteLine("Beşiktaş");
                    break;
                default:
                    Console.WriteLine("Bilinmeyen Takım");
                    break;
            }

            #endregion

            #region SimpleCalculator

            Console.WriteLine("\n*** Basit Hesap Makinesi ***");
            Console.Write("Birinci sayıyı girin: ");
            double num1;
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Lütfen geçerli bir sayı girin: ");
            }

            Console.Write("İkinci sayıyı girin: ");
            double num2;
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Lütfen geçerli bir sayı girin: ");
            }

            Console.Write("Yapmak istediğiniz işlemi seçin (+, -, *, /): ");
            char operation;
            while (!char.TryParse(Console.ReadLine(), out operation) ||
                   (operation != '+' && operation != '-' && operation != '*' && operation != '/'))
            {
                Console.Write("Lütfen geçerli bir işlem (+, -, *, /) girin: ");
            }

            double calcResult = 0;
            bool validOperation = true;

            switch (operation)
            {
                case '+':
                    calcResult = num1 + num2;
                    break;
                case '-':
                    calcResult = num1 - num2;
                    break;
                case '*':
                    calcResult = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        calcResult = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Bölme işlemi için ikinci sayı sıfır olamaz.");
                        validOperation = false;
                    }
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine("Sonuç: " + calcResult);
            }

            #endregion

            Console.WriteLine("\nProgramı kapatmak için bir tuşa basın...");
            Console.ReadLine();
        }
    }
}
