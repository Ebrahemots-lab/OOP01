using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassLibrary
{
    internal class LibDemo2
    {
        public LibDemo2()
        {
            //We can access X.Data here because LibDemo and LibDemo2 in the same assembly or project

            LibDemo x = new LibDemo();
            x.Data1 = "test";
            x.Data2 = 10;

            User U = new User();
            U.salary = 1000;
            
        }
    }
}
