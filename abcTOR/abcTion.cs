using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abcTOR
{
    public class abcTion
    {
        private int a, b;
        public abcTion(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Exectute(string pheptoan)
        {
            int kqua = 0;
            switch (pheptoan)
            {
                case "+":
                    kqua = a + b;
                    break;
                case "-":
                    kqua = a - b;
                    break;
                case "*":
                    kqua = a * b;
                    break;
                case "/":
                    kqua = a / b;
                    break;
            }
            return kqua;
        }


        public static double Power(double x, int n) //x =2 , n=3 , actual = 6 
        {
            if (n == 0)
                return 1.0;
            else if (n > 0)
                return n * Power(x, n - 1);
            else
                return Power(x, n + 1) / x;
        }
    }

}
    