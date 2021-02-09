using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NavrhoveVzoryUkol.Interface;


namespace NavrhoveVzoryUkol.Model
{
    class AgeValidator : IDateValidator
    {
        public bool IsValid(DateTime s) 
        { 
        DateTime now = DateTime.Now;
           if (now.Year - s.Year <= 130)
                return true;

            return false;
        }
    }
}
