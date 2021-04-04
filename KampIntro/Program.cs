using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            //string courseName1 = "SQL";
            //string courseName2 = "c#";

            Course course1 = new Course();
            course1.Name = "SQL";
            course1.Teacher = "Karcan Özbal";
            course1.Id = 1;

            Course course2 = new Course();
            course2.Name = "C#";
            course2.Teacher = "Engin Demiroğ";
            course2.Id = 3;

            Course[] courses = new Course[] {course1,course2 };

            foreach (var courseItem in courses)
            {
                Console.WriteLine($"Id = {courseItem.Id} , CourseName = {courseItem.Name} , Teacher = {courseItem.Teacher} ");
            }

        }
    }
}
