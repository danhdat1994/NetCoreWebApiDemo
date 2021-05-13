using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApiDemo
{
    public class CalculatorService
    {
        public CalculatorService()
        {

        }
        public int Add(int a,int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
