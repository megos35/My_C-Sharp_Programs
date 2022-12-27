int tahmin = 0, tutulan, sayac = 0;
Random rastgele = new Random();
tutulan = rastgele.Next(1, 100);
while (tahmin != tutulan)
{
    sayac++;

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("_________________");
    Console.WriteLine("*****************");
    Console.WriteLine("*****************");
    Console.WriteLine(" 1 ile 100 Arasında Bir Sayı Giriniz..:");
    Console.WriteLine("*****************");
    Console.WriteLine("*****************");
    Console.WriteLine("_________________");
    Console.WriteLine("");
    tahmin = Convert.ToInt32(Console.ReadLine());

    if (tahmin > tutulan)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("_________________");
        Console.WriteLine("*****************");
        Console.WriteLine("*****************");
        Console.WriteLine("Sayıyı Küçültünüz!!");
        Console.WriteLine("*****************");
        Console.WriteLine("*****************");
        Console.WriteLine("_________________");
    }
    else if (tahmin < tutulan)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("_________________");
        Console.WriteLine("*****************");
        Console.WriteLine("*****************");
        Console.WriteLine("Sayıyı Büyütünüz");
        Console.WriteLine("*****************");
        Console.WriteLine("*****************");
        Console.WriteLine("_________________");
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