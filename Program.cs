using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {   
            Point p1 =new Point();
            p1.x = 13;
            p1.y = 5;
            p1.sym = '&';
            p1.draw();
            Console.ReadLine();
         
        }
     
    }
}
