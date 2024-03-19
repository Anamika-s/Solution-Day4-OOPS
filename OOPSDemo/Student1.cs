using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    // A class shoud contain variables, properties, methods /...
    // by def, all the members of a class are privte
    // which means we cant acces them outside the class
    // by def class is internal , that we can access the class anywhere in the same  project
    // encapsulation > hiding the details frm the user
    // abstarction > showing the needed details to the user
    // we acheive both enc &* abst using access specifiers
 // whatever we want to hide , make them private
 // whatever we have to display, make them public

    class Student1
    
    {
        int rn;
        string name;
        static string batch;
        int marks;
        static int count;
        const string CollegeName = "JDU";
        public void GetDetails()
        {
            Console.WriteLine("Enter RollNo");
            rn = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            //Console.WriteLine("Enter Batch Name");
            //batch = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks = Byte.Parse(Console.ReadLine());
            count++;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"RollNo is {rn}");
            Console.WriteLine($"Name is {name}");
            //Console.WriteLine($"Batch is {batch}");
            Console.WriteLine($"Marks are {marks}");
        }
        public static void BatchDetails()
            {
            batch = "DotNet";
            
            Console.WriteLine("Batch Name is " + batch);
            Console.WriteLine("Total no." + count);
            Console.WriteLine("College NAme is " + CollegeName);
            

        }
    }
}
