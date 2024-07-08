using System.ComponentModel;
using System.Drawing;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01
            //Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.Then,
            //write a C# program that prints out all the days of the week using this enum

            //string[] days =  Enum.GetNames(typeof(WeeksDay));
            // foreach (string item in days) 
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 02
            //Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter) 
            //as its members.Write a C# program that takes a season name 
            //as input from the user and displays the corresponding month range for that season. Note range for seasons
            //( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.Write("Please enter season name: ");

            //string seasonName = Console.ReadLine();

            //bool isValidSeasonName = Enum.TryParse(seasonName,true, out Season result);

            //string Message = result switch
            //{
            //    Season.Spring => "March to May",
            //    Season.Summer => "June to august",
            //    Season.Autumn => "September to November",
            //    Season.Winter => "December to February",
            //    _ => "PLease choose valid season name"
            //};

            //Console.WriteLine(Message);

            #endregion

            #region 03
            ////Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum.
            //User user1 = new User();
            ////Add Permission to User 
            //user1.Permission = (Permission) 3; //Read, Write

            //user1.Permission = user1.Permission ^ Permission.Delete; // Add delete Permission

            //user1.Permission = user1.Permission ^ Permission.Delete; //Remove delete Permission

            ////Check if Delete Pemission existed or not 

            ////1 - 
            //if((user1.Permission & Permission.Delete) == Permission.Delete)
            //{
            //    Console.WriteLine($"{Permission.Delete} is already Exist");
            //}
            //else
            //{
            //    user1.Permission = user1.Permission ^ Permission.Delete;
            //    Console.WriteLine("Delete Permission Added Sucssesfuly");
            //}

            ////2 - 
            //user1.Permission = user1.Permission | Permission.Delete;



            //Console.WriteLine(user1.Permission);
            #endregion

            #region 04
            //Create an enum called "Colors" with the basic colors(Red, Green, Blue)
            //as its members.Write a C# program that takes a color name as input from
            //the user and displays a message indicating whether the input color is a primary color or not
            //Colors[] colors = Enum.GetValues<Colors>();

            //foreach (Colors color in colors)
            //{
            //    if (isPrime((int)color))
            //    {
            //        Console.WriteLine($"{color} Has prime Number");
            //    }
            //    else 
            //    {
            //        Console.WriteLine($"{color} isn't a prime number");
            //    }
            //}
            #endregion

            #region 05

            //Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program
            //that takes two points as input from the user and calculates the distance between them.

            //    Console.Write("Please enter point1 x: ");
            //    int x1 = int.Parse(Console.ReadLine());
            //    Console.Write("Please enter point1 y : ");
            //    int y1 = int.Parse(Console.ReadLine());
            //    Console.Write("Please enter point2 x: ");
            //    int x2 = int.Parse(Console.ReadLine());
            //    Console.Write("Please enter point2 y: ");
            //    int y2 = int.Parse(Console.ReadLine());


            //    Point p1 = new Point();
            //    p1.x = x1;
            //    p1.y = y1;
            //    Point p2 = new Point();
            //    p2.x = x2;
            //    p2.y = y2;

            //    double distance = CalculateDistance(p1, p2);
            //    Console.WriteLine(distance);
            //    #endregion
            //}

            //static bool isPrime(int number)
            //{
            //    if (number == 1)
            //    {
            //        return false;
            //    }
            //    if (number == 2)
            //    {
            //        return true;
            //    }
            //    for (int i = 2; i <= number / 2; ++i)
            //    {
            //        if (number % i == 0)
            //        {
            //            return false;
            //        }
            //    }

            //    return true;
            //}

            //static double CalculateDistance(Point p1 , Point p2) 
            //{
            //    double distanceX = p2.x - p1.x;
            //    double distanceY = p2.y - p1.y;

            //    return distanceX * distanceX + distanceY * distanceY;
            //}
            #endregion
        }

        enum WeeksDay
        {
            None = 0,
            Sunday = 1,
            Monday
        }

        enum Season
        {
            None = 0,
            Spring,
            Summer,
            Autumn,
            Winter
        }

        enum Colors
        {
            Red,
            Green,
            Blue,
        }


        struct Point
        {
            public int x;

            public int y;
        }

    }
}
