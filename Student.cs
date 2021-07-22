using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents individual student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// student's legal first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// studnet's legal last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// list of courses student is in
        /// </summary>
        public List<Course> Schedule { get; set; }

    }
}
