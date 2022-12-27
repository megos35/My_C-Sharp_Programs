// See https://aka.ms/new-console-template for more information


byte sayi = (byte)3.14f;                // başına byte yazdıkk fakat sayımız float bir sayı 
Console.WriteLine($"sayi {sayi}");      // programı çalıştırdığında farkettiysen 14 sayısı kayıp
Console.ReadKey();

byte num;
float boy = 1.75f;
num = (byte)(boy * 100);
Console.WriteLine(boy * 100);
Console.WriteLine($"Boyunuz : {num}");
Console.ReadLine();

String bisey = "12";
int say1 = Convert.ToInt32(bisey);
Console.WriteLine($"DONUSUM SONUCU = {say1 + 2}"); // burda stringi int e değiştiriyor ve + 2 ekledim
Console.ReadKey();