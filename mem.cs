using System;

namespace Liora
{
    public class Liora
    {
        public double Calc(double a, double b, double c, double x)
        {

            if ((c < 0) && (b != 0))
            {
                return (a * Math.Pow(x, 2)) + (Math.Pow(b, 2) * x);

            }
            else if ((c > 0) && (b == 0))                       
            {
              return (x + a) / (x + c);
            }
            else
            {
              return (a * x) / (c * Math.Pow(b, 2));
            }        
        }
    }
}
