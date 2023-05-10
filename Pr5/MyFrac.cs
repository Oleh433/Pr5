using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5
{
    struct MyFrac
    {
        public long nom, denom;
        public MyFrac(long nom_, long denom_)
        {
            nom = nom_; 
            denom = denom_;

            FixNumberSign(ref nom, ref denom);

            var largestDivider = ReduceFraction(Math.Abs(nom), Math.Abs(denom));

            nom /= largestDivider;
            denom /= largestDivider;
        }
        public override string ToString()
        {
            return $"{nom}/{denom}";
        }
        private long ReduceFraction(long nom, long denom)
        {
            while (denom != 0)
            {
                long remainder = nom % denom;

                nom = denom;

                denom = remainder;
            }

            return nom;
        }
        private void FixNumberSign(ref long nom, ref long denom)
        {
            if (denom < 0)
            {
                denom = Math.Abs(denom);

                if (nom < 0)
                {
                    nom = Math.Abs(nom);
                }
                else
                {
                    nom *= -1;
                }
            }
        } 

    }
}
