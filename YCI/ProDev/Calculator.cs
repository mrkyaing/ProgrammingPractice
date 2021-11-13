using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDev
{
    public class Calculator
    {
        public void Add2(ref int x)
        {
            x += 2000;
        }
        public void Add1(int x)
        {
            x += 2000;
        }
        public void Add3(out int x)
        {
            x = 3000;
        }

        public bool  IsEvenOrOdd(ref int n,ref int n2)
        {
            if (n % 2 == 0 && n % 2 == 0)
            {
                n++;
                n2++;
                return true;
            }
            return false;
        }
    }
}
