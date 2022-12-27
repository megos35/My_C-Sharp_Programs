
int not1, not2, not3;
Console.WriteLine("1.Notu Giriniz:");
// See https://aka.ms/new-console-template for more information
//Not Ortalaması Programı m.ege

int sayi, sayi2, sayi3;

Console.Write("1.Notu gir : ");

sayi = Convert.ToInt32(Console.ReadLine());

Console.Write("2.Notu gir : ");

sayi2 = Convert.ToInt32(Console.ReadLine());

Console.Write("3.Notu gir : ");

sayi3 = Convert.ToInt32(Console.ReadLine());

int v = (sayi + sayi2 + sayi3) / 3;

if (v <= 50)
{
    Console.Write("Dersten Kaldınız :(( ");
}
if (v >= 50)
{
    Console.Write("Dersten Gectiniz  ");
}

Console.ReadKey();