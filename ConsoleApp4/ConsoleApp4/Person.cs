using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Person
    {

        static Person()
        {
            Console.WriteLine("Person clasindan ilk defe istifade edildi");
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public int Id;
        public static int Count;

        public Person()
        {
            Id++;
            Count++;
        }

        public Person(string email)
        {
            if (Verifier.VerifyMail(email))
            {
                Email = email;
            }
        }

        public string GetInfo()
        {
            return $"{Id} - {Count}";
        }
        public static void Test()
        {

        }
    }
}
