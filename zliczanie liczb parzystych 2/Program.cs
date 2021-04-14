using System;

namespace zliczanie_liczb_parzystych_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int even = 0;
            int odd = 0;
            Random rand = new Random();
            int userInput = 0;
            for (int i = 1; i <= 100; i++)
            {
                userInput = rand.Next(0, 100);
                if (userInput % 2 == 0) even++;
                if (userInput % 2 == 1) odd++;
                Console.WriteLine(userInput);


            }
            Console.WriteLine($"Parzyste {even} Nieparzyste {odd}");
        }
    }
}
