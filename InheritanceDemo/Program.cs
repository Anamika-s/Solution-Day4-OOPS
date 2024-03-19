namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PartTime");
            PartTimeStudent partTimeStudent = new PartTimeStudent();
            partTimeStudent.GetDetails();
            //partTimeStudent.PartTimeGetDetails();
            partTimeStudent.DisplayDetails();
            //partTimeStudent.PartTimeDisplayDetails();


            Console.WriteLine("FullTime");
            FullTimeStudent fullTimeStudent = new FullTimeStudent();
            fullTimeStudent.GetDetails();
            //fullTimeStudent.GetDetailsForFullTime();
            fullTimeStudent.DisplayDetails();
            //fullTimeStudent.DisplayDetailsFullTime();
        }
    }
}