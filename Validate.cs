using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment1
{
    class Validate // validation calculate
    {
        public bool validateName(string name) //checks if name is a string
        {
            if (Regex.IsMatch(name, "^[a-zA-Z][a-zA-Z]*$"))
                {
                    return true;
                }
            return false;
        }

        public bool validateNumber(string num) //checks if numbers are correctly formated
        {
            if (Regex.IsMatch(num, "^\\d*(\\.\\d+)?$"))
            {
                return true;
            }
            return false;
        }
    }
}
