﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussRulesAB
{
    interface ISendEmails
    {
        void SendEmailTo(string Receipient, string Content);
    }
}
