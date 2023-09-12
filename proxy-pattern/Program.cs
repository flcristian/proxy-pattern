using proxy_pattern;

namespace Proxy.RealWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IMath math = new MathProxy();
            Console.WriteLine("4 + 2 = " + math.Add(4, 2));
            Console.WriteLine("4 - 2 = " + math.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + math.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + math.Div(4, 2));
        }
    }
}