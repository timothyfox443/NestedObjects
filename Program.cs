using System;
using System.Collections.Generic;


namespace NestedObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Instructor currInst = new Instructor()
            {
                FullName = "Huey Long",
                Email = "long.huey@greenparty.ca.org"
            };
            Student s1 = new Student()
            {
                FirstName = "Barthalomew",
                LastName = "Simpson"
            };
            Student s2 = new Student()
            {
                FirstName = "Lisa",
                LastName = "Simpson"
            };
            Student s3 = new Student()
            {
                FirstName = "Margaret",
                LastName = "Simpson"
            };
            Course testCourse = new Course();
            testCourse.Title = "CPW 212 - Adv .NET";
            testCourse.Description = "This is what you are doing right now";
            testCourse.Credits = 5;
            testCourse.CourseInstructor = currInst;
            testCourse.Roster = new List<Student>();
            testCourse.Roster.Add(s1);
            testCourse.Roster.Add(s2);
            testCourse.Roster.Add(s3);

            Console.WriteLine(testCourse.Title);
            Console.WriteLine("Is taught by "+ testCourse.CourseInstructor.FullName);

            Console.WriteLine("Currently enrolled students: ");
            foreach (Student s in testCourse.Roster)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}");
            }

            Console.ReadKey();
        }
    }
}
