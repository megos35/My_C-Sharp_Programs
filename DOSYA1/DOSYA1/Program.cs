FileStream fs = new FileStream("C:\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
StreamWriter sw = new StreamWriter(fs);
Console.Write("Adınız : ");
sw.WriteLine(Console.ReadLine());
sw.Close();
Console.WriteLine("Kayıt Eklendi.");
Console.ReadKey();