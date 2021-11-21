using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public interface ICreditCardService
    {
        void GetRupeesExchangeRate(double baseAmount);
        void GetDollorsExchangeRate(double baseAmount);
        void GetPoundsExchangeRate(double baseAmount);
        void GetSGDolorsExchangeRate(double baseAmount);
    }
}
