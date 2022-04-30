using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int N = int.Parse(Console.ReadLine()) /*длина массива*/, Max = 0, secondMax = 0;
            int[] a = new int[N];
            
            for (int i = 0; i < a.Length; i++)
            {
                try
                {
                    Console.Write("a[{0}]= ", i);
                    a[i] = int.Parse(Console.ReadLine());                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Для элемента a[{0}] введите цифру", i);
                    break;
                }
                if (a[i] > Max)
                {
                    secondMax = Max;
                    Max = a[i];
                }
                else if ((a[i] > secondMax) & (a[i] != Max))
                    secondMax = a[i];
            }
            Console.Write("\n" + "Второй максимальный элемент: {0}", secondMax);            
        }
    }
}
