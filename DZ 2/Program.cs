using System;

namespace DZ_2
{
    class Program
    {
        static int Main(string[] args)
        {
            int[] Numb = new int[3];
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                Numb[1] = random.Next(0, 100);
                Console.WriteLine(Numb[1]);
            }
            int min = Numb[0];
            if (min > Numb[1]) min = Numb[1];
            else if (min > Numb[2]) min = Numb[2];
            return min;
        }
    }
}
