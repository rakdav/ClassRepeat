using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRepeat
{
    class Account
    {
        private static decimal minSum = 100;
        public static decimal MinSum
        {
            get { return minSum; }
            set { if (value > 0) minSum = value; }
        }
        public decimal Sum { get; private set; }
        public decimal Rate { get; private set; }

        public Account(decimal sum, decimal rate)
        {
            if (sum < MinSum) throw new Exception("Недопустимая сумма");
            Sum = sum;
            Rate = rate;
        }

        public static decimal GetSum(decimal sum,decimal rate, int period)
        {
            decimal res = sum;
            for(int i=1;i<=period;i++)
            {
                res += res * rate / 100;
            }
            return res;
        }
    }
}
