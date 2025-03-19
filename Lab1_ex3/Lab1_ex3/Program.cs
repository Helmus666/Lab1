using System;

class Program
{
    static void Main()
    {
        // Виведення імені та прізвища студента
        Console.WriteLine("Виконав: [Андрущенко Роман]");

        Console.Write("Введіть ціну булочки (грн): ");
        double X = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть кількість булочок: ");
        int N = Convert.ToInt32(Console.ReadLine());

        double totalPrice = X * N;
        int hryvnias = (int)totalPrice;
        int kopecks = (int)Math.Round((totalPrice - hryvnias) * 100);

        Console.WriteLine($"Сума до сплати: {hryvnias} гривень {kopecks} копійок");
    }
}
