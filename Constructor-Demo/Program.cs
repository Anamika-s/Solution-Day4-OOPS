namespace Constructor_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // which cons is called first?
            
            Student student1 = new Student();
            student1.GetDetails();
            student1.DisplayDetails();

            Student student2 = new Student(10); // it will call para const1
            student2.DisplayDetails();

            Student student3 = new Student(11, "AJay");
            student3.DisplayDetails();

            Student student4 = new Student(12, "Ajay", 90);
            student4.DisplayDetails();


            Student student5 = new Student(student3); // it wil call copy cons
            student5.DisplayDetails();
        }
    }
}