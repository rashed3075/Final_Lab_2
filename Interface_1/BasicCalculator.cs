using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_1
{
    class BasicCalculator : IBasicCalculator
    {
        public int Division(int x, int y)
        {
            int c = x / y;
            return c;
            
        }

        public int Multiplication(int x, int y)
        {
            int c = x * y;
            return c;
        }

        public int Sub(int x, int y)
        {
            int c = x - y;
            return c;
        }

        public int Sum(int x, int y)
        {
            int c = x + y;
            return c;
        }
    }
}
