using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InvalidAgeException : ApplicationException
    {
        public InvalidAgeException() 
        {
            Console.WriteLine("Your age is not allowed to enter");
        }
    }
}
