using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NavrhoveVzoryUkol.Interface;

namespace NavrhoveVzoryUkol.Model
{
    class RodneCisloValidator : IRodneCisloValidator
    {
        public bool IsValid(string hodnota, int year)
        {
            if(year < 1954)
            {
                string pattern = @"\d{6}\/\d{3}";
                if(Regex.IsMatch(hodnota, pattern) && hodnota.Length == 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } 
            else
            {
                string pattern2 = @"\d{6}\/\d{4}";
                if (Regex.IsMatch(hodnota, pattern2) && hodnota.Length == 11)
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
}
