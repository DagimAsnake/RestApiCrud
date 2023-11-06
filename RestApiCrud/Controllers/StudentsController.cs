using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiCrud.Models;

namespace RestApiCrud.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        [Route("get-student-list")]
        public IActionResult GetStudentsList()
        {
            List<Student> students = new List<Student>();

            //--get student list from database
            students.Add(new Student { StudentId = 1, StudentName = "aa", Email = "aa@aa.com" });
            students.Add(new Student { StudentId = 2, StudentName = "bb", Email = "bb@bb.com" });
            students.Add(new Student { StudentId = 3, StudentName = "cc", Email = "cc@cc.com" });

            return Ok(students);
        }

        [HttpPost]
        [Route("create-student")]
        public IActionResult CreateStudent(Student student)
        {
            if(student == null || String.IsNullOrWhiteSpace(student.Email) || String.IsNullOrWhiteSpace(student.StudentName))
            {
                return BadRequest();
            }


            List<Student> students = new List<Student>();


            //--get student list from database
            students.Add(new Student { StudentId = 1, StudentName = "aa", Email = "aa@aa.com" });
            students.Add(new Student { StudentId = 2, StudentName = "bb", Email = "bb@bb.com" });
            students.Add(new Student { StudentId = 3, StudentName = "cc", Email = "cc@cc.com" });

            students.Add(student);
           
            return Ok(students);
        }

        [HttpGet]
        [Route("get-student-by-id/{StudentId}")]
        public IActionResult GetStudentById(int StudentId)
        {
            List<Student> students = new List<Student>();

            //--get student list from database
            students.Add(new Student { StudentId = 1, StudentName = "aa", Email = "aa@aa.com" });
            students.Add(new Student { StudentId = 2, StudentName = "bb", Email = "bb@bb.com" });
            students.Add(new Student { StudentId = 3, StudentName = "cc", Email = "cc@cc.com" });

            var student = students.Where(x => x.StudentId == StudentId).FirstOrDefault();

            return Ok(student);
        }

        [HttpPost]
        [Route("update-student")]
        public IActionResult UpdateStudent(Student student)
        {
            if (student == null || String.IsNullOrWhiteSpace(student.Email) || String.IsNullOrWhiteSpace(student.StudentName) || student.StudentId < 1)
            {
                return BadRequest();
            }


            List<Student> students = new List<Student>();

            //--get student list from database
            students.Add(new Student { StudentId = 1, StudentName = "aa", Email = "aa@aa.com" });
            students.Add(new Student { StudentId = 2, StudentName = "bb", Email = "bb@bb.com" });
            students.Add(new Student { StudentId = 3, StudentName = "cc", Email = "cc@cc.com" });

            students.Add(student);

            return Ok(students);
        }
    }
}
