using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDeleg
{
    class Program
    {
        static void Main(string[] args)
        {
            A a= new A('s');
            Console.WriteLine(a.P(5));
            Console.ReadKey();
        }

    }

    internal class A
    {
        public delegate int Power(int x);

        public Power P;

        private int square(int x)
        {
            return x*x;
        }

        private int cube(int x)
        {
            return x*x*x;
        }

        public A(char f) 
        {
            if (f == 's')
            {
                P = new Power(square);
            }
            else if (f == 'c')
            {
                P = new Power(cube);
            }
       }
    }

}
