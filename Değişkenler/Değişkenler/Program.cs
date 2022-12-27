{
    int dagYukseklıgı = 8849;
    int dagGenisligi = 3000;
    int bilgi = 23051953;// int te nokta virgil filan kullanamazsın , ve tam sayı olucak
    float PI = 3.14f;// 4 byte , kısa ama sayınınn sonuna harf koyuyorsun
    double boy = 1.75;// 8 byte
    byte yas = 16;// 1 byte,0 ile 255 arasında
    sbyte yas2 = -16;// sbyte olunca -128 --> +127 yani - yazabilirsin
    int ege = 10;

    Console.WriteLine("Everestin yükseklşiği {0} genişliği  {1} ve {2} tarihinde tırmanılmıştır", dagYukseklıgı, dagGenisligi, bilgi);// mavi yazılı yer sırayla ,sol taraftya sıra sana bağlı 

    Console.WriteLine($"{dagGenisligi} metre genişliğindedir");// üstteki yöntemin kısası 

    Console.WriteLine($" Pi sayısı {PI} dir ...");

    Console.WriteLine($" benim boyum {boy} dir ...");

    Console.WriteLine($"burada iki sayıyı yazıcam birinci sayı {yas} ikinci sayım ise {yas2}");// üstteki yas sayılarını yazdırdım böhyt

    Console.WriteLine(" {0} \n {0} ", ege);// bu \n alt satıra geçiriyor

    Console.WriteLine(" {0} \t {0}" , ege);// bu \t ise tab tuşuna basmış gibi 8 birim ileriye götürüyor

    Console.WriteLine($"\t\t{ege}\n\n\n\n\t\t{ege}");//burda dolar işareti kullanarak 10 yazdırdım ama arada hem alta geçirdim hemde ileri götürdüm yazıları



    Console.ReadKey();//bu yazı cmd deki ekranı kapatmıyor yani ekran kalıyor öyle
}
