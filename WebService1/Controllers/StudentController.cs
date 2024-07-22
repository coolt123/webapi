using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebService1.Entity;
using WebService1.Service;

namespace WebService1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] Student student)
        {
            try
            {
                var addedStudent = _studentService.AddStudent(student);
                return Ok(addedStudent);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] Student student)
        {
            try
            {
                _studentService.UpdateStudent(id, student);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            try
            {
                var student = _studentService.GetStudentById(id);
                return Ok(student);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            try
            {
                var students = _studentService.GetAllStudents();
                return Ok(students);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                _studentService.DeleteStudent(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
