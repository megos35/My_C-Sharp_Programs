
Random rastgele = new Random();
int[] sayilar = new int[10];
for(int i=0; i<10; i++)
{
    sayilar[i] = rastgele.Next(i, 10);
}
for(int i=0; i<10; i++)
{
    Console.WriteLine($"{i}.sayı:" + sayilar[i]);
}
Console.ReadKey();