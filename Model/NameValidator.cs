using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NavrhoveVzoryUkol.Interface;

namespace NavrhoveVzoryUkol.Model
{
    class NameValidator : INameValidator
    {
        public bool IsValid(string input)
        {
            if(input.Length >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}
