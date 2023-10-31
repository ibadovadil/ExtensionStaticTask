using ExtensionStaticTask.Models;

namespace ExtensionStaticTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullname;
            string groupNo;
            int age;

            Console.Write("Enter Name and Surname (Name Surname) ");
            fullname = Console.ReadLine();

            Console.Write("Enter group number  ");
            groupNo = Console.ReadLine();

            Console.Write("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());


            Student student = new Student(fullname, groupNo, age);

            Console.WriteLine($"Id: {student.Id}");
            Console.WriteLine($"Fullname: {student.Fullname}");
            Console.WriteLine($"GroupNo: {student.GroupNo}");
            Console.WriteLine($"Age: {student.Age}");
        }
    }
}