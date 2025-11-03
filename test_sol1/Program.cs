namespace test_sol1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Мини-калькулятор ===");

            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Сложение: {a} + {b} = {a + b}");
            Console.WriteLine($"Вычитание: {a} - {b} = {a - b}");
            Console.WriteLine($"Умножение: {a} × {b} = {a * b}");

            if (b != 0)
                Console.WriteLine($"Деление: {a} ÷ {b} = {a / b}");
            else
                Console.WriteLine("Деление на ноль!");
        }
    }
}
