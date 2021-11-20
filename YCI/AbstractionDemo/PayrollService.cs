using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    internal class PayrollService : IPayrollService
    {
        public void CalculateBonus()
        {
            throw new NotImplementedException();
        }

        public void CalculatePayroll()
        {
            throw new NotImplementedException();
        }
    }
}
