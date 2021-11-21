using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public interface ITaxService
    {
        //atstract method 
        double CalculateIncomeTax(int yearlyIncomeAmount);
        double CalcualteComsumerTax(int totalAmount);
    }
}
