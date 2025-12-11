using System;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, max = 1, s = 1;

            Console.Write("Enter an integer : ");
            n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("Entered integer is 1 and hence no factors");
                Console.ReadLine();
                Environment.Exit(0);
            }

            for (j = 2; j <= n / 2; j++)
            {
                if (n % j == 0)
                {
                    s = s + j;

                    for (i = 2; i <= j / 2; i++)
                    {
                        if (j % i == 0)
                            break;
                    }

                    if (i > j / 2)
                        max = j;
                }
            }

            if (n == s)
                Console.WriteLine("It is perfect");
            else
                Console.WriteLine("It is not perfect");

            if (max == 1)
                Console.WriteLine("largest prime number is " + n);
            else
                Console.WriteLine("largest prime number is " + max);

            Console.ReadLine();
        }
    }
}
