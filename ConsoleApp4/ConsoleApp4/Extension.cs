using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    static class Extension
    {

        public static bool CustomContains(this string mainString, char searchingFor)
        {
            foreach (char item in mainString)
            {
                if (item == searchingFor)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsValidMail(this string mail)
        {
            return mail.CustomContains('@') ? true : false;
        }

        public static int SumWith(this int n1, int n2)
        {
            return n1+n2;
        }
    }
}
