using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Member
    {
        public string Name { get; set; }
        public string MemberID { get; set; }

        public Member(string name, string memberID)
        {
            Name = name;
            MemberID = memberID;
        }

        public virtual void Notify(string msg)
        {
            Console.WriteLine($"Notification for {Name}: {msg}");
        }

    }
}
