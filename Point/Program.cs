using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1,2);
            p.setX(10);
            p.setY(6);

            Point p2 = new Point(3,4);
            p2.setX(11);
            p2.setY(17);
            p.Distance(p2);
            Console.WriteLine(p.Distance(p2));
            Console.WriteLine(p2.Distance(p));
            p.getX();
            p.getY();
            p2.getX();
            p2.getY();
            Console.WriteLine(p2.getX());
            Console.WriteLine(p2.getY());
            Console.WriteLine(p2.getX());
            Console.WriteLine(p2.getY());

        }
    }
}
