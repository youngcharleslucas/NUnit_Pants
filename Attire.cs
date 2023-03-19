using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WearPants
{
    public class Attire
    {
        public string WhatToWear( string day, string pant) 
        {
            StringBuilder decision = new StringBuilder();
            decision.Append($"It's {day}! ");

            if (day == Days.SATURDAY || day == Days.SUNDAY) 
                decision.Append("It's party time! ");
            else decision.Append($"It's business time. ");

            decision.Append($"I have to wear {pant} for this occasion.");

            return decision.ToString();
        }
    }
}
