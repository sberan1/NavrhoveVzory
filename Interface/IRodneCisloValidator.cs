using System;
using System.Collections.Generic;
using System.Text;

namespace NavrhoveVzoryUkol.Interface
{
    interface IRodneCisloValidator
    {
        bool IsValid(string hodnota, int year);
    }
}
