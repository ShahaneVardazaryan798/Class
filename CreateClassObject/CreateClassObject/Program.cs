using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CreateClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            WriteLine("Enter the age of student");
            std.Age = int.Parse(ReadLine());
            WriteLine(std.Age);
            Rectangle rct = new Rectangle();
            WriteLine("Enter the heigt of rectangle");
            rct.Height = int.Parse(ReadLine());
            WriteLine("Enter the width of rectangle");
            rct.Width = int.Parse(ReadLine());
            WriteLine("The area of rectangle = " + rct.Area);
        }
    }
}
