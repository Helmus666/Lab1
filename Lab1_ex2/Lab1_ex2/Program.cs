using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Виконав: [Андрущенко Роман]");

        Console.Write("Хвилин: ");
        int totalMinutes = Convert.ToInt32(Console.ReadLine());

        int hours = totalMinutes / 60;
        int minutes = totalMinutes % 60;

        Console.WriteLine($"{hours}:{minutes}");
    }
}