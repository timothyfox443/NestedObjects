using System.Collections.Generic;

namespace NestedObjects
{
    public class Course
    {
        /// <summary>
        /// course title IE Advanced .NET Proigramming
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Description of course
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// number of credits for couse completion
        /// </summary>
        public byte Credits { get; set; }
        /// <summary>
        /// this is the instructor that teaches the course - from instructor class
        /// </summary>
        public Instructor CourseInstructor { get; set; }
        /// <summary>
        /// all students assigned to this class list
        /// </summary>
        public List<Student> Roster { get; set; }


    }
}