﻿using BussRulesAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineAB
{
    class Video : IPackingSlip
    {
        public void GeneratePackingSlip(string Department, string Addon)
        {
            Console.WriteLine("Packing Slip for Department :" + Department);
            if (Addon.Length > 0)
            {
                Console.WriteLine("Addon as " + Addon);
            }

        }
    }
}
