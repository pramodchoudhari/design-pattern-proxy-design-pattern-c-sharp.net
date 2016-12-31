using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternInCSharp.Net.RealWorldExample
{
    public class HdfcATM : IThirdPartyBankATM
    {
        Double ATMCashLimit = 100000;

        public HdfcATM()
        {
                
        }

        public double GetBalance()
        {
            return ATMCashLimit;
        }

        public bool WithdrawnMoney(double amount)
        {
            ATMCashLimit -= amount;
            return true;
        }
    }
}
