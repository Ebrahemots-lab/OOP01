using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class User
    {
        public string Name;
        public int age;
        public Permission Permission;
    }

    [Flags]
    enum Permission 
    {
        Read = 1,
        Write = 2 ,
        Delete = 4 ,
        Execute = 8 
    }
}
