int bakiye = 1000;
bool devam = true;
while (true)
{

    Console.WriteLine("Bakiyeniz = " + bakiye);
    Console.WriteLine("\n**İSLEMLER**\n");
    Console.WriteLine("EGECELL");
    Console.WriteLine("1. Kontör Gönderme");
    Console.WriteLine("2. Kontör Yükleme");
    Console.WriteLine("3. Kontör Sorgulama");
    Console.WriteLine("4. Çıkış");

    Console.Write("\nİsleminizi Seciniz: ");
    int islem = Convert.ToInt32(Console.ReadLine());

    switch (islem)
    {
        case 1:
            Console.WriteLine("Bakiyeniz = " + bakiye);
            Console.Write("Çekmek istediğiniz tutarı giriniz: ");
            int tutar = Convert.ToInt32(Console.ReadLine());
            if (tutar > bakiye)
            {
                Console.Write("Yetersiz bakiye. Tekrar giriniz: ");
                tutar = Convert.ToInt32(Console.ReadLine());
            }
            bakiye -= tutar;
            Console.WriteLine("Yeni bakiyeniz = " + bakiye);
            break;
        case 2:
            Console.WriteLine("Bakiyeniz = " + bakiye);
            Console.Write("Yatırmak istediğiniz kontörü giriniz: ");
            tutar = Convert.ToInt32(Console.ReadLine());
            bakiye += tutar;
            Console.WriteLine("Yeni bakiyeniz = " + bakiye);
            break;
        case 3:
            Console.WriteLine("Bakiyeniz = " + bakiye);
            break;
            Console.ReadLine();
        case 4:
            devam = false;
            break;
        
    }
}
