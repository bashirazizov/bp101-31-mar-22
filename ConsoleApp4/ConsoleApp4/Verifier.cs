using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    static class Verifier
    {
        public static bool VerifyMail(string mail)
        {
            return mail.Contains("@") ? true : false;
        }

        public static bool VerifyPass(string pass)
        {
            return pass.Length>=8 ? true : false;
        }
    }
}
