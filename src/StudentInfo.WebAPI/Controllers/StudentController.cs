using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using StudentInfo.StudentRecords.Core.Interfaces;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentInfo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        IStudentRecordsRepository _repo;

        public StudentController(IStudentRecordsRepository repo)
        {
            _repo = repo;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<StudentRecords.Core.Model.Student> Get()
        {
            return _repo.GetAllStudents();
        }        
    }
}
