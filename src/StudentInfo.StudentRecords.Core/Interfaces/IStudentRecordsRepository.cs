using StudentInfo.StudentRecords.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo.StudentRecords.Core.Interfaces
{
    public interface IStudentRecordsRepository
    {
        IEnumerable<Student> GetAllStudents();

    }
}
