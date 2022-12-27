using System.Linq.Expressions;

while (true)
{
    int plaka;
    Console.Write("Plaka Giriniz : ");
    plaka = Convert.ToInt32(Console.ReadLine());
    switch (plaka)
    {
        case 35:
            Console.WriteLine("izmir");
            break;
        case 36:
            Console.WriteLine("kars");
            break;
        case 10:
            Console.WriteLine("balıkesir");
            break;
        case 45:
            Console.WriteLine("manisa");
            break;
        case 69:
            Console.WriteLine("bayburt");
            break;
        case 34:
            Console.WriteLine("istanbul");
            break;
        case 06:
            Console.WriteLine("ANKARA");
            break;
        case 01:
            Console.WriteLine("adana");
            break;
        case 02:
            Console.WriteLine("adıyaman");
            break;
        case 03:
            Console.WriteLine("afyon");
            break;
        case 04:
            Console.WriteLine("ağrı");
            break;
        case 05:
            Console.WriteLine("amasya");
            break;
        default:
            Console.WriteLine("plaka bulunamadı");
            break;
    }

}
    Console.ReadKey(); 