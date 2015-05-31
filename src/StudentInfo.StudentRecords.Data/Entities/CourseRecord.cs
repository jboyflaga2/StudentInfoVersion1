using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo.StudentRecords.Data.Entities
{
    public class CourseRecord
    {
        public Guid Id { get; set; }

        public DateTime DateStarted { get; set; }
        public DateTime DateFinished { get; set; }


    }
}
