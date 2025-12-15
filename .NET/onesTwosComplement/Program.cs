using System;
namespace numconversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, n, t, m, b, p;

            Console.Write("Enter a decimal number: ");
            n = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.Write("\nEnter 2/8/16 for base and 3 for exit: ");
                b = int.Parse(Console.ReadLine());

                switch (b)
                {
                    case 2:
                    case 8:
                        t = n;
                        p = 1;
                        m = 0;

                        if (t == 0)
                        {
                            if (b == 2)
                                Console.WriteLine("The binary equivalent = 0");
                            else
                                Console.WriteLine("The octal equivalent = 0");
                            break;
                        }

                        while (t != 0)
                        {
                            r = t % b;
                            m = m + r * p;
                            t = t / b;
                            p = p * 10;
                        }

                        if (b == 2)
                            Console.WriteLine("The binary equivalent = " + m);
                        else
                            Console.WriteLine("The octal equivalent = " + m);
                        break;

                    case 16:
                        t = n;
                        int c = 0;
                        char[] d = new char[32];

                        if (t == 0)
                        {
                            Console.WriteLine("The hexadecimal equivalent = 0");
                            break;
                        }

                        while (t != 0)
                        {
                            r = t % 16;

                            if (r < 10)
                                d[c] = Convert.ToChar(48 + r);   // '0' + r
                            else
                                d[c] = Convert.ToChar(55 + r);   // 'A' + (r - 10)

                            t = t / 16;
                            c++;
                        }

                        Console.Write("The hexadecimal equivalent = ");
                        for (int i = c - 1; i >= 0; i--)
                            Console.Write(d[i]);

                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice..");
                        break;
                }
            }
        }
    }
}
