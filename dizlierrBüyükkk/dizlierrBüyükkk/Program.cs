using System.Runtime.Serialization.Formatters;

int[] SAYILAR = { 64, 48, 67, 88, 102, 15, 55 };
int enBuyuk = SAYILAR[0];
for (int i = 1; i < 7; i++)
{
    if (enBuyuk < SAYILAR[i])
    {
        enBuyuk = SAYILAR[i];
    }
}
Console.WriteLine($"en buyuk sayı : {enBuyuk}");
Console.ReadKey();