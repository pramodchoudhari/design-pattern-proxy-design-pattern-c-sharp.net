using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPatternInCSharp.Net.StructuralCode
{
    public class RealSubject : ISubject
    {
        public void DoAction()
        {
            Console.WriteLine("Subject's Do Action");
        }
    }
}
