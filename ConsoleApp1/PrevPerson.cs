using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaikageAhmed1
{
    enum OldGeneration { BabyBoomer, GenX, Millenial, GenZ, GenAlpha, GenBeta }
    enum Generation { BabyBoomer, GenX, Millenial, GenZ, GenAlpha, GenBeta }

    /*
     * Realational Patterns Before & After 
     */
    internal class PrevPerson
    {
        // - Before
        public required int BirthYear { get; set; }
        public OldGeneration OldGeneration
        {
            get
            {
                if ((BirthYear >= 1946) && (BirthYear <= 1964))
                {
                    return OldGeneration.BabyBoomer;
                }
                else if ((BirthYear >= 1965) && (BirthYear <= 1980))
                {
                    return OldGeneration.GenX;
                }
                else if ((BirthYear >= 1981) && (BirthYear <= 1996))
                {
                    return OldGeneration.Millenial;
                }
                else if ((BirthYear >= 1997) && (BirthYear <= 2012))
                {
                    return OldGeneration.GenZ;
                }
                else if ((BirthYear >= 2013) && (BirthYear <= 2024))
                {
                    return OldGeneration.GenAlpha;
                }
                else
                {
                    return OldGeneration.GenBeta;
                }
            }
        }

        // - After
        // C# 9
        // '=>' expression body member tag syntax

        /*
         * Using a switch statement
         * which means here is a value to test, in this case 'BirthYear'
         * dictates the next thing
         */
        public Generation Generation => BirthYear switch
        {
            // BabyBoomer, GenX, Millenial, GenZ, GenAlpha, GenBeta 
            (>= 1946) and (<= 1964) => Generation.BabyBoomer,
            (>= 1965) and (<= 1980) => Generation.GenX,
            // using conjunctive 'and'
            (>= 1981) and (<= 1996) => Generation.Millenial, 
            (>= 1997) and (<= 2012) => Generation.GenZ,
            (>= 2013) and (<= 2024) => Generation.GenAlpha,
            // using discard operator intro => C# 7
            _ => Generation.GenBeta
        };
    }
}
