using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rastgele_sayı_oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int tahmin = 0, tutulan, sayac = 0;
            Random rastgele = new Random();
            tutulan = rastgele.Next(1, 100);
            while (tahmin != tutulan)
            {
                sayac++;

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("*****************");
                Console.WriteLine(" 1 ile 100 Arasında Bir Sayı Giriniz..:");
                Console.WriteLine("*****************");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin > tutulan)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("*****************");
                    Console.WriteLine("Sayıyı Küçültünüz!!");
                    Console.WriteLine("*****************");
                }
                else if (tahmin < tutulan)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("*****************");
                    Console.WriteLine("Sayıyı Büyütünüz");
                    Console.WriteLine("*****************");
                }
                if (sayac > 7)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Hakkınız Bitti");
                    Console.WriteLine("|==============================================|");
                    Console.WriteLine("|==============================================|");
                    Console.WriteLine("|==============================================|");
                    Console.WriteLine("|=======Hakkınız Bitti Yeniden Deneyiniz=======|");
                    Console.WriteLine("|==============================================|");
                    Console.WriteLine("|==============================================|");
                    Console.WriteLine("|==============================================|");
                    Console.WriteLine("Lütfen Tekrar Deneyiniz");
                    Console.ReadKey();
                    

                }

            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Tebrikler Sayıyı Buldunuz");
            Console.WriteLine("{0}. hakkınızda bildiniz", sayac);
            Console.ReadKey();
        }
    }
}
