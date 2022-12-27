// Klavyeden Girilen Sayının Tek mi ? Çift mi ? Olduğunu Anlayan Program
int sayi;
Console.Write("Sayı gir : ");
sayi = Convert.ToInt32(Console.ReadLine());
if (sayi % 2 == 0)
{
    Console.Write($"{sayi} sayısı çift bir sayıdır");
}
else
{
    Console.Write("{0} sayısı tek bir sayıdır", sayi);
}
Console.ReadKey();
