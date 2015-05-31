using StudentInfo.StudentRecords.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentInfo.StudentRecords.Core.Model;

namespace StudentInfo.StudentRecords.Data.Repositories
{
    public class StudentRecordsRepository : IStudentRecordsRepository
    {
        public IEnumerable<Student> GetAllStudents()
        {
            return new List<StudentRecords.Core.Model.Student>
            {
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jboy",
                    LastName = "Flaga"
                }
            };
        }
    }
}
