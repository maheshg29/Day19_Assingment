using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Assingment
{
    public class UserRegistration
    {

        public static string REGEX_NAME = "^[A-Z]{1}[a-z]{2}[a-z]*";

            public bool validatename(string userdata)
            {
                return Regex.IsMatch(userdata, REGEX_NAME);
            }
        
    }
}
