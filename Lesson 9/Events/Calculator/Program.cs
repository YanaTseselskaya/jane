using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter count = new Counter(0);
            count.Message1 += DisplayOnConsole1;
            count.Message2 += DisplayOnConsole2;
            count.Evoke(0);
        }
        public static void DisplayOnConsole1(Counter sender, Handler1 e) => Console.WriteLine(e.Message);
        public static void DisplayOnConsole2(Counter sender, Handler2 e) => Console.WriteLine(e.Message);
    }
}
