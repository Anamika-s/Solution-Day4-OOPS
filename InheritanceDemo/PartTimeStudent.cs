//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace InheritanceDemo
//{
//    internal class PartTimeStudent : Student
//    {
//        string timeSlot;
//        public void PartTimeGetDetails()
//        {
//            Console.WriteLine("Enter Slot");
//            timeSlot = Console.ReadLine();
//        }

//        public void PartTimeDisplayDetails()
//        {
//            Console.WriteLine("Time Slot is" + timeSlot);
//        }
//    }
//}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class PartTimeStudent : Student
    {
        string timeSlot;
        public void GetDetails()
        //public void PartTimeGetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter Slot");
            timeSlot = Console.ReadLine();
        }


        public void DisplayDetails()

        //public void PartTimeDisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Time Slot is" + timeSlot);
        }
    }
}



