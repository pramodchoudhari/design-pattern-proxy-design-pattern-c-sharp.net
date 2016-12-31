using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternInCSharp.Net.StructuralCode
{
    public class Proxy : ISubject
    {
        RealSubject _realSubject;
        public Proxy()
        {
            _realSubject = new RealSubject();
        }
        public void DoAction()
        {
            Console.WriteLine("Proxy's Do Action");
            _realSubject.DoAction();
        }
    }
}
