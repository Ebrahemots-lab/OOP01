using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassLibrary
{
    public struct MyStruct
    {
        //Acess Modifiers inside struct
        //Private
        //Public
        //internal

        //Constructor => Special type of Function
        //Same name as class or struct
        // didn't return anything 

        public int x;
        public int y;


        public MyStruct(int x1, int y1) //user defined constructor
        {
            x = x1;
            y = y1; 
        }

        public override string ToString()
        {
            return $"{x} , {y}";
        }


    }
}
