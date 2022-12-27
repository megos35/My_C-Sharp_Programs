String[] arabalar = { "WolksWagen", "AUDI", "BMW", "Renault", "Seat", "Ford", "Mercedes-Benz","Opel","Honda","Toyota","Skoda","Chevrolet","Alfa Romeo","Cıtroen","Fıat","Tofas","Volvo" };
Console.WriteLine($"Listede{arabalar.Length}adet arac vardır");
for (int i = 0; i < arabalar.Length; i++)
{
    Console.WriteLine(arabalar[i]);

}
Console.WriteLine("------------Sıralı Liste------------");
Array.Sort(arabalar);
for(int i = 0; i < arabalar.Length; i++)
{
    Console.WriteLine(arabalar[i]);
}
Console.ReadKey();