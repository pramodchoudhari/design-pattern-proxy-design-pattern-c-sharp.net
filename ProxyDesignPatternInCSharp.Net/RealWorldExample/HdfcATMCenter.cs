using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternInCSharp.Net.RealWorldExample
{
    public class HdfcATMCenter : IThirdPartyBankATM
    {
        HdfcATM hdfc { get; set; }
        public HdfcATMCenter()
        {
            hdfc = new HdfcATM();
        }
        public double GetBalance()
        {
            return hdfc.GetBalance();
        }

        public bool WithdrawnMoney(double amount)
        {
            return hdfc.WithdrawnMoney(amount);
        }
    }
}
