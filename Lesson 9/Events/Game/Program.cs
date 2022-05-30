using System;

namespace Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();            
            Ping ping = new Ping(rand.Next(0, 10));
            Pong pong = new Pong(rand.Next(0, 10));
            ping.PingPlay += DisplayPing;
            pong.PongPlay += DisplayPong;
            ping.Players(rand.Next(0, 10), rand.Next(0, 10));
            pong.Players(rand.Next(0, 10), rand.Next(0, 10));
        }
        public static void DisplayPing(Ping sender, PingHandler e) => Console.WriteLine(e.Message);
        public static void DisplayPong(Pong sender, PongHandler e) => Console.WriteLine(e.Message);
    }
}
