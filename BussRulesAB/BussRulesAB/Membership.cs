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
        public int ID { get; set; }
        public string Type { get; set; }

        public void Activate(int id, string type)
        {
            SendEmailTo("User " + id, "Membership Activated of Type " + type);
        }

        public void SendEmailTo(string Receipient, string Content)
        {
            Console.WriteLine("Email sent to " + Receipient + " with Content " + Content);
        }

        public void Upgrade(int id, string type)
        {
            SendEmailTo("User " + id, "Membership Upgraded of Type " + type);
        }
    }
}
