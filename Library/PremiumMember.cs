using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PremiumMember : Member
    {
        public PremiumMember(string name, string memberID) : base(name, memberID) { 
        
        }

        public override void Notify(string msg)
        {
            Console.WriteLine($"Premium notification for {Name}: {msg}");
        }
    }
}
