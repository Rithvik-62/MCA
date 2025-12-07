using System;

class FibonacciMenu
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n---- Fibonacci Menu ----");
            Console.WriteLine("1. Display specified count of Fibonacci numbers");
            Console.WriteLine("2. Display Fibonacci numbers within a range");
            Console.WriteLine("3. Display Fibonacci numbers up to a specified number");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayCount();
                    break;

                case 2:
                    DisplayRange();
                    break;

                case 3:
                    DisplayUpto();
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 4);
    }

    static void DisplayCount()
    {
        Console.Write("Enter count of Fibonacci numbers: ");
        int n = int.Parse(Console.ReadLine());

        int f1 = 0, f2 = 1, f3;

        Console.WriteLine("\nFibonacci series:");

        for (int i = 1; i <= n; i++)
        {
            
            f3 = f1 + f2;
            Console.Write(f3 + " ");
            f1 = f2;
            f2 = f3;
        }

        Console.WriteLine();
    }

    static void DisplayRange()
    {
        Console.Write("Enter start of range: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter end of range: ");
        int end = int.Parse(Console.ReadLine());

        int f1 = 0, f2 = 1, f3;

        if (start > end)
        {
            Console.WriteLine("Invalid range! Start cannot be greater than end.");
            return;
        }

        Console.WriteLine("\nFibonacci numbers in the range:");
        while (f1 <= end)
        {
            if (f1 >= start)
                Console.Write(f1 + " ");

            f3 = f1 + f2;
            f1 = f2;
            f2 = f3;
        }

        Console.WriteLine();
    }

    static void DisplayUpto()
    {
        Console.Write("Enter the limit value: ");
        int limit = int.Parse(Console.ReadLine());

        int f1 = 0, f2 = 1, f3;

        Console.WriteLine("\nFibonacci numbers up to limit:");

        while (f1 <= limit)
        {
            Console.Write(f1 + " ");

            f3 = f1 + f2;
            f1 = f2;
            f2 = f3;
        }

        Console.WriteLine();
    }
}
