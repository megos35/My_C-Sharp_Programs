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
if(sayi>=50 && sayi2>=50 && sayi3>=50)
{
    Console.WriteLine("Tebrikler,Dersi Geçtiniz");
}
else
{
    Console.WriteLine("Maalesef Dersi Geçemediniz");
}
    Console.WriteLine($"Not Ortalamanız :{v}");

  
Console.ReadKey();
