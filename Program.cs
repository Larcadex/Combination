using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            int selected = 0;

            Console.WriteLine("Выберите нужную формулу:");
            Console.WriteLine("\n1. Сочетание без повторений");
            Console.WriteLine("2. Сочетание с повторениями");

            ConsoleKeyInfo keyInfo1 = Console.ReadKey(true);

            switch (keyInfo1.Key)
            {
                case ConsoleKey.D1:
                    selected = 0;
                    break;
                case ConsoleKey.D2:
                    selected = 1;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Неверный выбор, попробуйте еще раз\n");
                    Main();
                    break;
            }

            Console.Clear();

            Console.WriteLine("Введите значение n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Введите значение k: ");
            int k = int.Parse(Console.ReadLine());
            Console.Clear();

            if (n < 0 || k < 0 || k > n)
            {
                Console.Clear();
                Console.WriteLine("Неверные значения n и k. Убедитесь, что 0 <= k <= n.\n");
                Main();
            }

            switch (selected)
            {
                case 0:
                    selected = 0;
                    Console.WriteLine($"C({n}, {k}) = {Combination(n, k)}");
                    break;
                case 1:
                    Console.WriteLine($"C({n}, {k}) = {CombinationWithRepetition(n, k)}");
                    break;
            }

            int selected1 = 0;

            Console.WriteLine("\nХотите ввести данные еще раз?:");
            Console.WriteLine("\n1. Да");
            Console.WriteLine("2. Нет");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                    selected1 = 0;
                    Console.Clear();
                    break;
                case ConsoleKey.D2:
                    selected1 = 1;
                    Console.Clear();
                    Console.WriteLine("Программа завершена");
                    return;
            }
        }

    }

    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    static int Combination(int n, int k)
    {
        return Factorial(n) / (Factorial(k) * Factorial(n - k));
    }

    static int CombinationWithRepetition(int n, int k)
    {
        return Factorial(n + k - 1) / (Factorial(k) * Factorial(n - 1));
    }


}