using System;

class Arithmetic
{
	static void Main()
    {
        int num1;
        int num2;
        double sum;

        Console.Write("Enter first integer: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer: ");
        num2 = int.Parse(Console.ReadLine());
        sum = num1 + num2;

        Console.WriteLine($"Sum is {sum}");
        sum = num1 * num2;
        Console.WriteLine($"Product is {sum}");
        sum = num1 - num2;
        Console.WriteLine($"Difference is {sum}");
        sum = num1 / num2;
        Console.WriteLine($"Quotient is {sum}");
    }
}
