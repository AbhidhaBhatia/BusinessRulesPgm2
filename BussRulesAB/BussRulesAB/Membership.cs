using BussRulesAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineAB
{
    class Membership : ISendEmails
    {
        public int id;
        public string type;
        public void Activate(int id)
        {
            SendEmailTo("User " + id, "Membership Activated");
        }

        public void SendEmailTo(string Receipient, string Content)
        {
            Console.WriteLine("Email sent to " + Receipient + " with Content " + Content);
        }

        public void Upgrade(int id)
        {
            SendEmailTo("User " + id, "Membership Upgraded");
        }
    }
}
