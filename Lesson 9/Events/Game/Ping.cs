
namespace Game
{
    public class Ping
    {
        public delegate void Pin(Ping sender, PingHandler message);
        public event Pin PingPlay;
        public int Number { get; private set; }
        public Ping(int num) => Number = num;
        public void Players(int num1, int num2)
        {
            PingPlay?.Invoke(this, new PingHandler("Ping gets Pong"));
            if (num1 < num2)
                PingPlay?.Invoke(this, new PingHandler("Pong won!"));
            else if (num1 == num2)
                PingPlay?.Invoke(this, new PingHandler("End game!"));
        }
    }
}
