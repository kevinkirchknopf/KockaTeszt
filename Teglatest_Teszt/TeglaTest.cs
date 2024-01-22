using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teglatest_Teszt
{
    public class TeglaTest
    {
        private int A, B, C;

        public int Terfogat(int A, int B, int C)
        {
            return A * B * C;
        }

        public int Felszin(int A, int B, int C) 
        {
            return 2 * (A * B + B * C + C * A);
        }

        public double Atlo(int A, int B, int C) 
        {
            return Math.Round(Math.Sqrt(A*A + B*B + C*C), 2);
        }

    }
}
