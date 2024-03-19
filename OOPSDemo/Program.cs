using System.Collections;
using System.Collections.Generic;

namespace OOPSDemo
{

    internal class Program
    {
        static void Main(string[] args)
        {
           // //declaration
           // Student student;
           // // initialization
           // student= new Student();
           //// dec & init are done together
           // Student student1 = new Student();
           // // Here student a7 student are objects of class Student
           // // int i;
           // student.GetDetails();
           // student.DisplayDetails();

            //Student student1 = new Student();
            //// new keyword will do two things
            //// 1. It allocates memory for the object frm heap
            //// 2. It initializes all the member variables to their def values
            //student1.GetDetails();
            //student1.DisplayDetails();

            //Student student2 = new Student();
            //student2.GetDetails();
            //student2.DisplayDetails();

            //Student student3 = new Student();
            //student3.GetDetails();
            //student3.DisplayDetails();

            // Array of Objects

            //Student[] students = new Student[10];
            //for(int i=0;i<3;i++)
            //{
            //    students[i] = new Student();
            //    students[i].GetDetails();
               

            //}

            //foreach(Student student in students)
            //{
            //   student.DisplayDetails();
            //}

           //ArrayList list = new ArrayList(); 
           //Student student1 = new Student();

           // list.Add(student1);

           // Student student2 = new Student();
           // list.Add(student2);

           // list.Add(1);
           // list.Add("aaa");

           // foreach(Student student in list)
           // {
           //     student.DisplayDetails();
           // }

            // use generic collection
            List<Student> students = new List<Student>();
            //Student student = new Student();
            //student.GetDetails();
            //students.Add(student);
            string ch = "y";
            int i = 0;
            Student student;
            while(ch=="y")
            {    Console.WriteLine($"ENter Detaiks of STudent No {++i}");
                student = new Student();
                student.GetDetails();
                students.Add(student);
                Console.WriteLine("Do you want to add mire records");
                ch = Console.ReadLine();
            }



           foreach (Student temp in students)
            {
                temp.DisplayDetails();
            }




        }
    }
}