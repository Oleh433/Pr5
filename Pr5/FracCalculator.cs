using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5
{
    internal static class FracCalculator

    {

        public static double DoubleValue(MyFrac f)
        {
            return (double)f.nom / f.denom;
        }

        public static MyFrac Add(MyFrac f1, MyFrac f2)
        {
            long nom = (f1.nom * f2.denom) + (f2.nom * f1.denom);
            long denom = f1.denom * f2.denom;

            return new MyFrac(nom, denom);
        }

        public static MyFrac Subtract(MyFrac f1, MyFrac f2)
        {
            long nom = (f1.nom * f2.denom) - (f2.nom * f1.denom);
            long denom = f1.denom * f2.denom;

            return new MyFrac(nom, denom);
        }

        public static MyFrac Multiply(MyFrac f1, MyFrac f2)
        {
            long nom = f1.nom * f2.nom;
            long denom = f1.denom * f2.denom;

            return new MyFrac(nom, denom);
        }

        public static MyFrac Divide(MyFrac f1, MyFrac f2)
        {
            long nom = f1.nom * f2.denom;
            long denom = f1.denom * f2.nom;

            return new MyFrac(nom, denom);
        }

        public static MyFrac CalcSum1(int n)
        {
            MyFrac frac = new MyFrac(0, 1);

            for (int i = 1; (double)frac.nom / frac.denom < (double)n / (n + 1); i++)
            {
                frac = Add(new MyFrac(1, i * (i + 1)), frac);
            }

            return frac;
        }

        public static MyFrac CalcSum2(int n)
        {
            MyFrac frac = new MyFrac(1, 1);

            for (int i = 2; ((double)frac.nom / frac.denom > (double)(n + 1) / (2 * n)); i++)
            {
                frac = Multiply(new MyFrac((long)Math.Pow(i, 2) - 1, (long)Math.Pow(i, 2)), frac);
            }

            return frac;
        }
    }
}
