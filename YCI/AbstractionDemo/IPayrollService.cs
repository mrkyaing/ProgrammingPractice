using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public interface IPayrollService
    {
        //abstract method 
       void CalculatePayroll();
       void CalculateBonus();
    }
}
