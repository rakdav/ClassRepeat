using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRepeat
{
    class Calculator
    {
        public void Add(int a,int b)
        {
            int res = a + b;
            Console.WriteLine(res);
        }

        public void Add(int a,int b,int c)
        {
            int res = a + b + c;
            Console.WriteLine(res);
        }

        public double Add(int a,double b)
        {
            return a + b;
        }

        public double Add(int a,double b,int c)
        {
            return a + b + c;
        }
    }
}
