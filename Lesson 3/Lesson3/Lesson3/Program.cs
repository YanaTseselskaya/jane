using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1ое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2ое число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("Выберете операцию: +, -, *, /");
            string operat = Console.ReadLine(), output;            
            switch (operat)
            {
                case "+":
                    output = string.Format("Результат: {0}", num1 + num2);
                    Console.WriteLine(output);
                    break;
                case "-":
                    output = string.Format("Результат: {0}", num1 - num2);
                    Console.WriteLine(output);
                    break;
                case "*":
                    output = string.Format("Результат: {0}", num1 * num2);
                    Console.WriteLine(output);
                    break;
                case "/":
                    try
                    {
                        output = string.Format("Результат: {0}", num1 / num2);
                        Console.WriteLine(output);
                    }
                    catch
                    {
                        if (num2 == 0)
                            Console.WriteLine("Ошибка! 2ое число не должно быть равным 0");
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка! Неизвестный знак");
                    break;                
            }            
        }
    }
}
