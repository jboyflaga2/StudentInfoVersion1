using System;
using System.Collections.Generic;

namespace StudentInfo.StudentRecords.Core.Model
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IEnumerable<CourseRecord> CourseRecords { get; set; }
    }
}
