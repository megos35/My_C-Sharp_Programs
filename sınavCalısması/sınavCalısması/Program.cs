for (int i = 0; i < 7; i++)
{
    for (int k = i; k < 7; k++)
        Console.Write(""); // sola yaslamak için boşluğu kaldırmanız yeterlidir
    {
        for (int x = 0; x <= i; x++)
        {
            Console.Write("*");
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}
Console.Read();