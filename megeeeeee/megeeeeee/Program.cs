

int kontor = 30;
while (true) ;
{
    Console.Clear();
    Console.WriteLine("***** İSLEMLER *****");
    Console.WriteLine("1- KONTOR GONDERME");
    Console.WriteLine("2- KONTOR YUKLEME");
    Console.WriteLine("3- KONTOR SORGULAMA");
    Console.WriteLine("4- CIKIS");
    Console.Write("Isleminiz Nedir ?");
    int islem = Convert.ToInt32(Console.ReadLine());
    switch (islem)
    {
        case 1:
            Console.WriteLine("Ne Kadar Kontor Yukleyeceksiniz ...");
            int yukle = Convert.ToInt32(Console.ReadLine());
            kontor = kontor + yukle;
            Console.WriteLine($"Guncel Bakiyeniz:{kontor}");
            Console.ReadKey();
            break;
        case 2:
            Console.WriteLine($"Guncel Bakiyeniz :{kontor}");
            Console.ReadKey();
            break;






    }
}
