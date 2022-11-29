using System;

namespace SimulationParticle
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 3);
            Point c = new Point(4, 4);
            double speed = 0.2;
            Console.WriteLine(Simulate(a, c, speed));
        }
        public static string Simulate(Point a, Point c, double spead)
        {
            double minTime = 100;
            while (true)
            {

            }


            return "";
        }
    }
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
