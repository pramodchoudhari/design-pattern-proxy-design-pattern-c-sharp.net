using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternInCSharp.Net.RealWorldExample
{
    public interface IThirdPartyBankATM
    {
        double GetBalance();
        bool WithdrawnMoney(double amount); 
    }
}
