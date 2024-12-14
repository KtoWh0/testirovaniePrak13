using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число n для вычисления 2^n и суммы его цифр (n <= 63):");

        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0 && n <= 63)
        {
            long result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= 2;
            }

            Console.WriteLine($"Результат 2^{n}: {result}");

            int sum = 0;
            foreach (char digit in result.ToString())
            {
                sum += digit - '0';
            }

            Console.WriteLine($"Сумма цифр числа 2^{n}: {sum}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода! Введите целое неотрицательное число, не превышающее 63.");
        }
        Console.ReadKey();
    }
}
