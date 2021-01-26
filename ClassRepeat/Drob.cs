using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRepeat
{
    class Drob
    {
        private int a;
        private int b;

        public Drob(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public Drob(int a):this(a,1)
        {
            //this.a = a;
            //this.b = 1;
        }

        public Drob Plus(Drob drob)
        {
            int m = this.a * drob.b + this.b * drob.a;
            int n = this.b * drob.b;
            return new Drob(m, n);
        }
        public void Print()
        {
            Console.WriteLine(this.a/Nod(this.a,this.b)+"/"+this.b/ Nod(this.a, this.b));
        }
        private int Nod(int a,int b)
        {
            if (a == 0)
            {
                return b;
            }
            else
            {
                while (b != 0)
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }

                return a;
            }
        }
    }
}
