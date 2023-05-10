using static Pr5.FracCalculator;

namespace Pr5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyFrac fr1 = new MyFrac(5, 10);
            Console.WriteLine(ToStringWithIntegerPart(fr1));

            MyFrac fr2 = new MyFrac(3, -18);
            Console.WriteLine(fr2.ToString());
            Console.WriteLine(ToStringWithIntegerPart(fr2));

            Console.WriteLine(ToStringWithIntegerPart(Add( fr1, fr2)));
            Console.WriteLine(ToStringWithIntegerPart(Subtract( fr1, fr2)));

            Console.WriteLine(ToStringWithIntegerPart(Multiply(fr1, fr2)));
            Console.WriteLine(ToStringWithIntegerPart(Divide(fr1, fr2)));

            MyFrac fr3 = CalcSum1(3);
            Console.WriteLine(fr3.ToString()); 

            MyFrac fr4 = CalcSum2(4);
            Console.WriteLine(fr4.ToString());
        }

        static string ToStringWithIntegerPart(MyFrac f)
        {
            string result;
            long wholePart = Math.Abs(f.nom / f.denom);

            if (Math.Abs(f.nom) >= Math.Abs(f.denom))
            {
                if (f.nom < 0)
                {
                    return $"-({wholePart} + {Math.Abs(f.nom % f.denom)}/{f.denom})";
                }

                return $"{wholePart} + {Math.Abs(f.nom % f.denom)}/{f.denom}";
            }

            return $"{f.nom}/{f.denom}";
        }
    }
}