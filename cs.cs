using System;

namespace Testlabs
{
    class TestLab
    {
        public void Calc()
        {
            double F;
            Console.WriteLine("Введите: a, b, c, x");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());

            if ((c < 0) && (b != 0))
            {
                F = a * Math.Pow(x, 2) + Math.Pow(b, 2) * x;
                Console.WriteLine("Ответ: " + F);
            }
            else
            {
                if ((c > 0) && (b == 0))
                {
                    F = (x + a) / (x + c);
                    Console.WriteLine("Ответ: " + Math.Round(F, 3));
                }
                else
                {
                    F = (a * x) / (c * Math.Pow(b, 2));
                    Console.WriteLine("Ответ: " + Math.Round(F, 3));
                    
                }

            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            TestLab a = new TestLab();
            a.Calc();
        }
    }

}
