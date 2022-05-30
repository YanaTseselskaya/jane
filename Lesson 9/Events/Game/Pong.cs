
namespace Game
{
    public class Pong
    {
        public delegate void Pon(Pong sender, PongHandler message);
        public event Pon PongPlay;
        public int Number { get; private set; }
        public Pong(int num) => Number = num;
        public void Players(int num1, int num2)
        {
            PongPlay?.Invoke(this, new PongHandler("Pong gets Ping"));
            if (num2 < num1)
                PongPlay?.Invoke(this, new PongHandler("Ping won!"));
            else if (num2 == num1)
                PongPlay?.Invoke(this, new PongHandler("End game!"));
        }    
    }
}
