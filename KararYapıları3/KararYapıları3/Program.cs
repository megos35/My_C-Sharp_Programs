//Not Ortalaması Programı m.ege

int sayi, sayi2, sayi3;

Console.Write("1.Notu gir : ");

sayi = Convert.ToInt32(Console.ReadLine());

Console.Write("2.Notu gir : ");

sayi2 = Convert.ToInt32(Console.ReadLine());

Console.Write("3.Notu gir : ");

sayi3 = Convert.ToInt32(Console.ReadLine());

int v = (sayi + sayi2 + sayi3) / 3;

Console.WriteLine($"*******Not Ortalamanız*******");
Console.WriteLine($"            {v}");

if (v>=0 && v<50)
{
    Console.Write("    Notunuz -E-");
}
else if (v >= 50 && v < 60)
{
    Console.Write("    Notunuz -D-");
}
else if (v >= 60 && v < 70)
{
    Console.Write("    Notunuz -C-");
}
else if (v >= 70 && v < 85)
{
    Console.Write("    Notunuz -B-");
}
else if (v >= 85 && v <= 100)
{
    Console.Write("    Notunuz -A-");
}
Console.ReadKey();
