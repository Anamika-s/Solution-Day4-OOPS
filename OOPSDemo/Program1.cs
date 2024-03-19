using System.Collections;
using System.Collections.Generic;

namespace OOPSDemo
{

    internal class Program1
    {
        static void Main(string[] args)
        {

            //Student1.batch = "DotNet";
            List<Student1> students = new List<Student1>();
            //Student student = new Student();
            //student.GetDetails();
            //students.Add(student);
            string ch = "y";
            int i = 0;
            Student1 student;
            while(ch=="y")
            {    Console.WriteLine($"ENter Detaiks of STudent No {++i}");
                student = new Student1();
                student.GetDetails();
                students.Add(student);
                Console.WriteLine("Do you want to add mire records");
                ch = Console.ReadLine();
            }


            Student1.BatchDetails();

            foreach (Student1 temp in students)
            {
                temp.DisplayDetails();
            }




        }
    }
}