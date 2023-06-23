using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbe:");
        int height = int.Parse(Console.ReadLine());

        int width = height * 2 - 1;
        int center = width / 2;

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (col >= center - row && col <= center + row)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}