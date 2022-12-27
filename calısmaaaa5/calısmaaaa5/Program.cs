Random rastgele = new Random();
int[] sayilar = new int[100];
for (int i = 0; i < 100; i++)
{
    sayilar[i] = rastgele.Next(1, 100);
}
for (int i = 0; i < 100; i++)
{
    Console.WriteLine($"{i} inci sayı :" + sayilar[i]);
}
Console.ReadKey();