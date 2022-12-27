// See https://aka.ms/new-console-template for more information

using System.Net.WebSockets;

byte yas = 16;
Console.WriteLine($"Yas ={yas} (aslında 16,4)");// byte 0 ile 255
Console.ReadKey();

sbyte yas2 = -16;
Console.WriteLine($"Yas2 ={yas2}");// sbyte -128 ile 127
Console.ReadKey();

short bısıkletfıyat = 3200;                                 // short -32768 ile 32768 , ushort 0 ile 65535
Console.WriteLine("Bısıklet Fıyatı = {0} TL" , bısıkletfıyat); // bohyt bu sekilde de yazabilirsin 
Console.ReadKey();

int nufus = 81000000;
Console.WriteLine($"TR nufusu = {nufus} kısı"); // 2.147.483.648 e kadar yolu var ve aynı sekilde "-" de olur  "uint" in 4.294.967.295 e kadar yolu var :))
Console.ReadKey();

float PI = 3.14f; // f koyman lazım 
Console.WriteLine($"PI sayısı {PI}dır");
Console.ReadKey();

double avagadroSayisi = 6.02214199834756875;         // bu teeee milyara kadar gidiyor
Console.WriteLine($"avagadro sayısı {avagadroSayisi}");
Console.ReadKey();

char basHarf = 'M';                                  // tek tırnak kullanıcaksın
Console.WriteLine($"ismimin ilk harfi {basHarf} dir");
Console.ReadKey();

string ısım = "Mustafa Ege";
Console.WriteLine($"ismim {ısım} dır,uzunlugu {ısım.Length} kadardır");
Console.ReadKey();

bool durum = true;
Console.WriteLine($"durumumuz{durum}");
Console.ReadKey();
