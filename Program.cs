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
            Console.WriteLine("Передача имени метода в подпрограмму:\n");
            del d = new del(C1.f);
            double a = 0, b = 1, s;
            int n = 100;
            s = Integral(d, a, b, n);
            Console.WriteLine("s={0}", s);
            Console.Write("\nPress any key to continue . . . ");
            Console.ReadKey(true);
        }

        public static double Integral(del f, double a, double b, int n)
        {
            double x, s = (f(a) + f(b)) / 2, h = (b - a) / n;
            for (int i = 1; i < n; i++)
            {
                x = a + i * h;
                s += f(x);
            }
            s *= h;
            return s;
        }

    }

    public delegate double del(double x);
    class C1
    {
        public static double f(double x)
        {
            return x * x;
        }
    }
    

}
