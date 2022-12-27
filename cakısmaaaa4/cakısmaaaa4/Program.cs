int sayi = 0;
int toplam = 0;
while (sayi < 10)
{
    sayi++;
    Console.WriteLine(sayi);
    toplam += sayi;
}
Console.WriteLine($"Toplam ={toplam}");
Console.ReadKey();