using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Виконав: [Андрущенко Роман]");

        Console.Write("Введіть кількість комп'ютерів у класі №1: ");
        int C1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть кількість комп'ютерів у класі №2: ");
        int C2 = Convert.ToInt32(Console.ReadLine());

        C1 += 1; 
        C2 += 2; 

        Console.WriteLine($"Оновлена кількість комп'ютерів у класі №1: {C1}");
        Console.WriteLine($"Оновлена кількість комп'ютерів у класі №2: {C2}");
    }
}
