using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Type a limit: ");
        int limitA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type another limit: ");
        int limitB = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (limitA > limitB)
        {
            if (num > limitA)
            {
                Console.Write($"You have entered {num} which is greater than {limitA} which is the maximum\nResulting integer: {limitA}");
            }
            if (num < limitB)
            {
                Console.Write($"You have entered {num} which is lower than {limitB} which is the minimum\nResulting integer: {limitB}");
            }
        }
        else if
        {
            if (num > limitB)
            {
                Console.Write($"You have entered {num} which is greater than {limitB} which is the maximum\nResulting integer: {limitB}");
            }
            if (num < limitA)
            {
                Console.Write($"You have entered {num} which is lower than {limitA} which is the minimum\nResulting integer: {limitA}");
            }
        }
        else
        {
            Console.Write("You're within boundaries");
        }
    }
}
