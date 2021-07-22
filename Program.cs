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

            Course c2 = new Course()
            {
                Title = "CPW 245 Data Structures"
            };

            Course c3 = new Course()
            {
                Title = "CPW 213 .NET Web Programming"
            };

            Course testCourse = new Course
            {
                Title = "CPW 212 - Adv .NET",
                Description = "This is what you are doing right now",
                Credits = 5,
                CourseInstructor = currInst,
                Roster = new List<Student>()
            };

            testCourse.Roster.Add(s1);
            testCourse.Roster.Add(s2);
            testCourse.Roster.Add(s3);

            //s3.Schedule.Add(c2);
            //s3.Schedule.Add(c3);
            //s3.Schedule.Add(testCourse);




            Console.WriteLine(testCourse.Title);
            Console.WriteLine("Is taught by "+ testCourse.CourseInstructor.FullName);

            Console.WriteLine("Currently enrolled students: ");
            foreach (Student s in testCourse.Roster)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}");
            }
            //Console.WriteLine("Courses Currently enrolled in: ");
            //foreach (Course c in s3.Schedule)
            //{
            //    Console.WriteLine($"{c.Title}");
            //}


            Console.ReadKey();
        }
    }
}
