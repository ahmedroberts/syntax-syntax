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
                else
                {
                    return OldGeneration.GenBeta;
                }
            }
        }

        // - After
        public Generation Generation => BirthYear switch
        {
            (2000) => Generation.GenZ,
            _ => Generation.GenBeta
        };
    }
}
