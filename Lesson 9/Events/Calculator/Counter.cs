using System;

namespace Calculator
{
    public class Counter
    {
        public delegate void CounterHandler1(Counter sender, Handler1 e);
        public event CounterHandler1 Message1;
        public delegate void CounterHandler2(Counter sender, Handler2 e);
        public event CounterHandler2 Message2;
        public int Number { get; private set; }
        public Counter(int num) => Number = num;
        public void Evoke(int num)
        {
            while (num < 100)
            {
                num++;
                Console.WriteLine($"Current number: {num}");
                if (num == 77) 
                    Message1?.Invoke(this, new Handler1($"Пора действовать ведь уже {num}!"));
                if (num == 88)
                    Message2?.Invoke(this, new Handler2($"Уже {num}! Давно пора начать действовать!"));                
            }
        }               
    }
}
