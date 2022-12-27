Console.WriteLine("DÜZ ÜÇGEN YAPIMI");
for (int i = 1; i <= 10; i++) // yukarıdan aşağıya tek tek 10 satır ataması için 
{
    for (int j = 0; j < i; j++) // soldan sağa yıldızları teker teker arttırarak yazdırdığı kısım 

    // ikinci for'u iptal edersek alt alta 10 adet yıldız yazdırır ama ilk for satırını iptal edersek program çalışmaz
    {
        Console.Write("*"); // bu kısımda Write olması bizim için yıldızları yan yana yazdırması anlamını taşır
    }
    Console.WriteLine();
}
Console.Read();