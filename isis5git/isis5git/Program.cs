using System;

namespace isis5git
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation=0;
            double firstNumber=0, secondNumber=0;
            while (true)
            {
                Console.WriteLine("Введите число, чтобы начать операцию:\n1. Сложение\n2. Вычитание \n3. Умножение\n4. Деление\n");
                operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case (1):
                        Console.WriteLine("Выбрана операция сложения. Введите первое число\n");
                        firstNumber = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число\n");
                        secondNumber = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат сложения чисел = " + (firstNumber + secondNumber) + "\n");
                        break;
                    case (2):
                        Console.WriteLine("Выбрана операция Вычитания. Введите первое число\n");
                        firstNumber = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число\n");
                        secondNumber = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат вычитания чисел = " + (firstNumber - secondNumber) + "\n");
                        break;
                    case (3):
                        Console.WriteLine("Выбрана операция умножения. Введите первое число\n");
                        firstNumber = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число\n");
                        secondNumber = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результат умножения чисел = " + (firstNumber * secondNumber) + "\n");
                        break;
                    case (4):
                        Console.WriteLine("Выбрана операция деления. Введите первое число\n");
                        firstNumber = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число\n");
                        secondNumber = Convert.ToDouble(Console.ReadLine());
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Ошибка! Деление на ноль запрещено!");
                            break;
                        }
                        Console.WriteLine("Результат деления чисел = " + (firstNumber / secondNumber) + "\n");
                        break;
                }
                operation = 0;
            }
        }
    }
}
