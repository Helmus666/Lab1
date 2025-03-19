using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Виконав: [Андрущенко Роман]");

        double x = 12.5;

        Console.Write("Значення a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        double y = 8.5 * Math.Pow(x, (9 + 3 * a) / (a + 1));

        Console.WriteLine($"x = {x}");
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"y = {y}");
        Console.WriteLine($"√y = {Math.Sqrt(y)}");
        Console.WriteLine($"x^4 = {Math.Pow(x, 4)}");
    }
}