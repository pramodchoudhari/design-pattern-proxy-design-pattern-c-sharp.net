using ProxyDesignPatternInCSharp.Net.RealWorldExample;
using ProxyDesignPatternInCSharp.Net.StructuralCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternInCSharp.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy _proxy = new Proxy();
            _proxy.DoAction();


            HdfcATMCenter hdfcATM = new HdfcATMCenter();
            Console.WriteLine("Balance" + hdfcATM.GetBalance());
            hdfcATM.WithdrawnMoney(200);
            Console.WriteLine("Balance" + hdfcATM.GetBalance());
            Console.ReadLine();

        }
    }
}
