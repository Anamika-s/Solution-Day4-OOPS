using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Demo
{
    class Student

    {
        int rn;
        string name;
        static string batch;
        int marks;
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
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"RollNo is {rn}");
            Console.WriteLine($"Name is {name}");
            //Console.WriteLine($"Batch is {batch}");
            Console.WriteLine($"Marks are {marks}");
        }
        public Student()
        {

        }

        public Student(int rn)
        {
            this.rn = rn;
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            //Console.WriteLine("Enter Batch Name");
            //batch = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks = Byte.Parse(Console.ReadLine());
        }

        public Student(int rn ,  string name)
        {
            this.rn = rn;
            this.name = name;
            //Console.WriteLine("Enter Batch Name");
            //batch = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks = Byte.Parse(Console.ReadLine());
        }

        public Student(int rn, string name, int marks)
        {
            this.rn = rn;
            this.name = name;
            //this.batch = batch;
            this.marks = marks; 
        }


        public Student(Student student)
        {
            Console.WriteLine("Enter RollNo");
            rn = Byte.Parse(Console.ReadLine());
            this.name =  student.name;
            //this.batch = student.batch;
            this.marks = student.marks;
        }
        // static cons are paramterless and we dont use any access specifier
        static Student()
        {
            batch = "DotNet";
        }
    }
}
