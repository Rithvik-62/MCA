using System;

class OnesTwosComplement
{
    static void Main()
    {
        int r, n, t, m, p, flag = 0;
        int[] onesbit = new int[10];
        int[] twosbit = new int[10];

        Console.WriteLine("Enter a decimal Number : ");
        n = int.Parse(Console.ReadLine());

        p = 1;
        m = 0;
        int i = 0;

        t = n;   // store original value

        while (n != 0)
        {
            r = n % 2;
            m = m + r * p;
            n = n / 2;
            p = p * 10;

            // 1's complement
            onesbit[i] = (r == 0) ? 1 : 0;

            // 2's complement logic using flag
            if (flag == 0)
            {
                twosbit[i] = r;     // copy bits until first 1
                if (r == 1)
                    flag = 1;
            }
            else
            {
                twosbit[i] = (r == 0) ? 1 : 0; // invert bits
            }

            i++;
        }

        Console.WriteLine("\nBinary equivalent : " + m);

        Console.Write("Ones complement : ");
        for (int j = i - 1; j >= 0; j--)
            Console.Write(onesbit[j]);
        Console.WriteLine();

        Console.Write("Twos complement : ");
        for (int j = i - 1; j >= 0; j--)
            Console.Write(twosbit[j]);
        Console.WriteLine();
    }
}
