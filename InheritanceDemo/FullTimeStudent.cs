using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class FullTimeStudent : Student
    {
        string batch;

        public void GetDetails()
        //public void GetDetailsForFullTime()
        {
            base.GetDetails();
            Console.WriteLine("Enter Batch");
            batch = Console.ReadLine();
        }

        public void DisplayDetails()

        //public void DisplayDetailsFullTime()
        {
            base.DisplayDetails();
            Console.WriteLine("Batch is " + batch);
        }
    }
}
