using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Student
    {
        int rn;
        string name;
        
        int marks;
        public void GetDetails()
        {
            Console.WriteLine("Enter RollNo");
            rn = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
           
            Console.WriteLine("Enter Marks");
            marks = Byte.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"RollNo is {rn}");
            Console.WriteLine($"Name is {name}");
           
            Console.WriteLine($"Marks are {marks}");
        }
    }
}
