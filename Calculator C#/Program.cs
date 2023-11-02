using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Квадратный корень");
            Console.WriteLine("7. 1 процент от числа");
            Console.WriteLine("8. Факториал");
            Console.WriteLine("9. Выход");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 9)
            {
                break;
            }

            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());

            if (choice != 6 && choice != 8)
            {
                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Результат: " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Результат: " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Результат: " + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Результат: " + (num1 / num2));
                        break;
                    case 5:
                        Console.WriteLine("Результат: " + Math.Pow(num1, num2));
                        break;
                    case 7:
                        Console.WriteLine("Результат: " + (num1 * 0.01));
                        break;
                }
            }
            else
            {
                switch (choice)
                {
                    case 6:
                        Console.WriteLine("Результат: " + Math.Sqrt(num1));
                        break;
                    case 8:
                        int factorial = 1;
                        for (int i = 1; i <= num1; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine("Результат: " + factorial);
                        break;
                }
            }

            Console.WriteLine();
        }
    }
}