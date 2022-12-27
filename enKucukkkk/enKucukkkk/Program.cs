int[] SAYILAR = { 64, 48, 67, 88, 102, 15, 55,134,246,1568,45,1,-4,-99 };
int enBuyuk = SAYILAR[0];
int enKucuk = SAYILAR[0];
for (int i = 1; i < SAYILAR.Length; i++)
{
    if (enBuyuk < SAYILAR[i])
    {
        enBuyuk = SAYILAR[i];
    }
   else if (enKucuk > SAYILAR[i])
    {
        enKucuk = SAYILAR[i];
    }
}

int total = SAYILAR.Sum();
int v = (total) / SAYILAR.Length;

Console.WriteLine($" ortalama : {v}");
Console.WriteLine($"en buyuk sayı : {enBuyuk}");
Console.WriteLine($"en kucuk sayı : {enKucuk}");
Console.ReadKey();