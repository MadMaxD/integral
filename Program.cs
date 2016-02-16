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
            
            del d = fun.f;
            double s;
            int a = 0;
            int b = 13;
            int n = 10;
            s = Integral(d, a, b, n,'p');
            Console.WriteLine("Интеграл x^2 (прямоугольника) на интервале {0} {1} I={2} ", a,b,s);
            s = Integral(d, a, b, n, 't');
            Console.WriteLine("Интеграл x^2 (трапеций) на интервале {0} {1} I={2} ", a, b, s);
           
            Console.ReadKey();
        }
        public static double Integral(del f, double a, double b, int n, char c)
        {
            double x;
            double s = 0;
            double h;
            if (c == 'p')
            {
                h = (b - a) / n;
                for (double i = 1; i <= n; i++)
                {
                    x = a + h*(i - 0.5);
                    s += f(x);
                }

                s *= h;
            }
            else if (c == 't')
            {
                s = (f(a) + f(b)) / 2;
                h = (b - a) / n;
                for (int i = 1; i < n; i++)
                {
                    x = a + i * h;
                    s += f(x);
                }
                s *= h;
            }
            else
            {
                s = -1;
            }
            return s;
        }
        
    }


    public delegate double del(double x);
    class fun
    {
        public static double f(double x)
        {
            return x * x;
        }
    }

}
