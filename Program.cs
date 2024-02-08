using System;

public class TribonacciSequence
{
    public static int NextTerm(int a, int b, int c)
    {
        return a + b + c;
    }

    public static int NthTerm(int n)
    {
        if (n == 0)
            return 0;
        else if (n == 1 || n == 2)
            return 1;

        int a = 0, b = 0, c = 1;
        int nextTerm = 0;

        for (int i = 3; i <= n; i++)
        {
            nextTerm = NextTerm(a, b, c);
            a = b;
            b = c;
            c = nextTerm;
        }

        return nextTerm;
    }

    public static void Main(string[] args)
    {
        int termsToCalculate = 10;

        Console.WriteLine("First " + termsToCalculate + " terms of the Tribonacci sequence:");

        for (int i = 0; i < termsToCalculate; i++)
        {
            Console.WriteLine("Term " + i + ": " + NthTerm(i));
        }
    }
}
