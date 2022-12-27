while (true)
{
    int sayi;
    Console.WriteLine("Bir sayı girin:");
    sayi = Convert.ToInt32(Console.ReadLine());
    while(sayi >= 0)
    {
        Console.WriteLine("negatif bir sayi degildir");
        Console.WriteLine("Bir sayı girin:");
        sayi = Convert.ToInt32(Console.ReadLine());
    }
    if (sayi < 0)
    {
        Console.WriteLine("negatiftir ");
        break;
    }

}
Console.ReadKey();