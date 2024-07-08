using DemoClassLibrary;
using DemoClassLibrary.Enums;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exception Handling
            /*
             * What is Exception Handling?
             * it's a way to prevent your program to throw an error when using it 
             * simply you try to avoid erros ocuers in runtime 
             * 
             * Steps : 
             * You need to Write a protective Code then you can use try catch at the end if you have doubt about 
             * your code.
             * 
             * What is an Exceptions?
             * simple it's like a man who warning you about something in your program to fix the problem 
             * and the user of the program shouldn't know about this Thing
             * we Can save the exceptions that will occured in LogFile - Database
             */

            /*
             * Exceptions Hierarchy
             * All Exceptions in C# come from the Parent class Exception 
             * there is two types of Exceptions : 
             * 1 - SystemExceptions : built in - the Parent of SystemExceptions
             * 2 - ApplicationException : user Defined Exceptions
             */
            #endregion

            #region Exception Handling Examples

            #region Ex01
            //string[] colors = { "red", "green", "blue" };

            //Console.WriteLine(colors[6]);

            //Notice it will not give a warining or error because the exception will be ocured in the run time
            //We are try to access index number 5 in the colors array which size is 3 
            //First we need to write a protective code 
            //we need to check if the Length of the array is larger than or equal 6 
            //if no Do nothing.
            //If yes print the element 
            #endregion

            #region Ex02
            //try
            //{
            //    string[] colors = null;

            //    if (colors?.Length >= 6 || colors != null)
            //    {
            //        Console.WriteLine(colors[6]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry You Enterd a wrong Index");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"{ex.GetType} says {ex.Message} ");
            //}
            //finally
            //{
            //    Console.WriteLine("Iam Done");
            //}
            #endregion

            #region Ex03
            /*
             * Write a program that ask the user to enter a number then print number * 2 if the number is right
             * 
             */

            //bool isValidNumber;
            //int result;
            //do
            //{
            //    Console.Write("PLease enter a number: ");

            //    isValidNumber = int.TryParse(Console.ReadLine(), out result);
            //}
            //while (!isValidNumber);

            //Console.WriteLine(result);


            #endregion

            #endregion

            #region Acess Modifiers
            /*
             * Inside Namspace we can create
             * Class - Enum - Struct - Interface
             * Acess Modifiers Allowed inside Namespace(public - internal[default])
             * 
             * internal -> Allowed In only it's Project or Assembly
             * Public -> allowed in it's assembly and Any other Assembly
             */

            //ClassLibrary: Dons't have main function - when compiling the compiler will convert it's contect into DLL
            //We need to Import Class library into our Main Project 
            /*
             * Right Click on Our project then add Reference then choose the class library
             * then (using the Library)
             */
            LibDemo x = new LibDemo(); //LibDemo has Public access Modifier so we can access it from Anywheare

            /*LibDemo2 = new LibDemo2();*/ //Invalid because LibDemo2 has Internal access Modifier


            //We can give the data inside the Class 6 Acess Modifiers
            User user1 = new User(); // Create object from class
            //user1.name = "Test"; // Invalid because Access Modifiers of the attribute is private by default

            user1.name = "Ebrahem"; // valid -> After changing attriute access Modifier from private to public

            //user1.age = 10 //Invaid because age has internal acess Modifier so it's only accessable isnide it's assembly


            #endregion


            #region Enums
            /*
             * Enums -> value type  , Defined by keyword enum 
             * it has Labels Inside it 
             * Compiler take this lables and convert them to int values 
             * so if we need to store enum value in Database we will store it as Int
             */

            /*
             * Sytanx
             * 
                enum Days 
                {
                    Satuday, // 0 
                    Sunday, // 1 
                    Monday, // 2
                }

                it has an int values Start with 0
             */

            //Benifits of using Enums
            //You can Make you code Clean for example if i need to make an option in my accplicaion and this option
            //has Gender and this Gender is : Male - Femal we simply spicify Enum with labels Male - Femal then we use it
            //Instead of using String 

            //Days day = Days.Monday;
            /*  Console.WriteLine(day);*/ //Monday

            //Another way to convert Get enum label based on it's number 
            //string result = Enum.GetName(typeof(Days),0);
            //Console.WriteLine(result);

            //We can use if to check if a day founded in Enum or not 

            //if(day == Days.Monday) 
            //{
            //    Console.WriteLine("Yes");
            //}


            //Enum.Parse
            //Console.WriteLine("PLease enter a day: ");

            //string? day = Console.ReadLine();

            //object obj  =Enum.Parse(typeof(Days),day);

            //Days w = (Days) obj;

            //Console.WriteLine(w);


            //Enum.TryParse

            //Console.WriteLine("PLease enter a day: ");

            //string? day = Console.ReadLine();

            //bool isValidDay = Enum.TryParse(typeof(Days),day,true,out object z);

            //if (isValidDay) 
            //{
            //    Console.WriteLine($"The day {(Days) z!}");
            //}
            //else
            //{
            //    Console.WriteLine("Day not found");
            //}


            //Using Generics
            //try 
            //{
            //    Days d = Enum.Parse<Days>(Console.ReadLine(), true);
            //    Console.WriteLine(d);
            //}catch(ArgumentException ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Days o = new Days(); //Default Constructor
            //Console.WriteLine(o);


            //Enums Flags to store multible values

            Emp emp1 = new Emp();
            emp1.name = "Ebrahem";

            emp1.prem = (Premessions)3; //Two Permessions
            emp1.prem = emp1.prem ^ Premessions.Update;

            ////Console.WriteLine(emp1.prem);

            ////Add Permissions
            ////Do XOR (^) -> 
            ///*
            // * 0011
            // * 1000
            // * -----
            // * 1011
            // */

            //Console.WriteLine(emp1.prem);


            //If you want to check if label is already existed or not 
            //Do & operations
            //check person permision against the premission you want to check
            //emp.premissions & permission.update -> will return the permission you search if it's found 
            /*
             *1011
             * &
             *1000
             *-----
             *1000 -> 8 Exicted
             * 
             */

            //if ((emp1.prem & Premessions.Update) == Premessions.Update) 
            //{
            //    //If 
            //    Console.WriteLine("Update is found");
            //}
            //else
            //{
            //    Console.WriteLine("Permission not found");
            //}

            //second way If you want to check if permission existed or not 
            //Do Or Operation
            /*
             * 1011
             * 1000
             * -------
             * 1011 //Already Founded
             */

            //emp1.prem = emp1.prem | Premessions.Update;
            //Console.WriteLine(emp1.prem);
            #endregion


            #region Struct

            //We can give the data inside the Struct 3 Acess Modifiers (Private - internal - public)
            //Anything access Modifier include Protected this is go with Inheretance so we can't Use it inside struct
            //Because struct dosn't allow Inhiretance

            //Acess Modifiers inside struct
            //Private
            //Public
            //internal


            //MyStruct S = new MyStruct();
            //Console.WriteLine(S.x);

            MyStruct s1 = new MyStruct(10,20); //New used to choose constructor only
            //s1.x = 20;
            Console.WriteLine(s1.x);

            Console.WriteLine(s1.ToString()); //override method
            Console.WriteLine(s1); //boxing and unboxing 


            MyStruct s2 = new(); // another way to intialize constructor (.net 5)
            Console.WriteLine(s2.x);

            #endregion


        }

        [Flags]
        enum Premessions : byte
        {
            None = 0,
            Witre = 1 ,  //0b-0000-0001
            Read= 2,     //0b-0000-0010
            Delete = 4,  //0b-0000-0100
            Update = 8,  //0b-0000-1000
                        //    8 4  2  1

            //Write - Delete - update 
            //0001
            //0100
            //1000
            //1101
        }


        class Emp 
        {
            public string name;
            public int age;
            public Premessions prem;
        }
    }


}
