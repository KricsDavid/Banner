using System.Drawing;

namespace Banner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('■');
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine('■');

            Banner kep = new Banner();
            kep[2, 5] = new Color(32, 3, 4, 2);
        }
    }
}
