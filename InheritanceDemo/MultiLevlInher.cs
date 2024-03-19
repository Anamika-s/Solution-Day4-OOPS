using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    internal class Student
    {
        int rn;
        string name;
        public void GetDetails()
        {
            Console.WriteLine("Enter RollNo");
            rn = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();

        }
        public void DisplayDetails()
        {
            Console.WriteLine($"RollNo is {rn}");
            Console.WriteLine($"Name is {name}");

        }
    }

    class Sports : Student
    {
        string sportsName;
        public int score;
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter sportsName");
            sportsName = Console.ReadLine();
            Console.WriteLine("Enter score");
            score = Byte.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("sportsName is " + sportsName);
            Console.WriteLine("score is " + score);

        }
    }

    class Test : Sports
    {
        int[] marks = new int[] { 90, 23, 34, 56, 66 };
        public int totalMarks = 0;
        public void CalculateTotalMarks()
        {
            base.GetDetails();
           foreach(int mark in marks)
            {
                totalMarks += mark;
            }
        }

        public void DisplayDetails()
        {

            base.DisplayDetails();
            Console.WriteLine("totalMarks are "  + totalMarks);
        }
    }

    class Result : Test
    {
        int totalScore;


        public void CalculateTotalScore()
        {
            base.CalculateTotalMarks();
            totalScore = totalMarks + score;

        }

        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("TotalScore is "  + totalScore);
        }



    }
}
