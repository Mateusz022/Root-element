using System;

namespace Pierwiastek_samodzielnie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double epsilon = 0.000001;
            double a,
            x = 1;
            Console.WriteLine("podaj wartość zmiennej a");
            a = Convert.ToDouble(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("zgłaszam wyjątek", a); //throw new exception
            } while (Math.Abs(x * x - a) > epsilon)
            {
                x = (x + a / x) / 2;
            }
            Console.WriteLine("Wartością (przybliżoną) pierwiastka kwadratowego liczby {0} jest {1}.", a, x);
            Console.WriteLine("Wartością pierwiastka kwadratowego liczby {0} jest {1}.", a, Math.Sqrt(a));
            Console.ReadKey();

        }
    }
}
