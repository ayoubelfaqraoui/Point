using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Point

    {


        private double x;

        private double y;



        public Point(double x, double y)

        {

            this.x = x;

            this.y = y;

        }


        public void setX(double x)  
        {
            this.x = x; 
          }

        public void setY(double y) 
         {
            this.y = y; 
              }

        public double getX() 

        {  
            return x; 

        }

        public double getY() 
        { 

            return y; 
        }


        public double Distance(Point p)

        {

            return Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));

        }


        public bool Equals(Point p)

        {

            return (x == p.x && y == p.y);

        }



        public Point Translate(double dx, double dy)

        {

            return new Point(x + dx, y + dy);

        }



        public Point Linearity(Point p1, Point p2)

        {

            return new Point(x * p1.x + y * p2.x, x * p1.y + y * p2.y);

        }

    }
 

}

