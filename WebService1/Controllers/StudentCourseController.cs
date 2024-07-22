using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebService1.Entity;
using WebService1.Service;

namespace WebService1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentCourseController : ControllerBase
    {
        private readonly IStudentCourseService _studentCourseService;

        public StudentCourseController(IStudentCourseService studentCourseService)
        {
            _studentCourseService = studentCourseService;
        }

        [HttpPost("enroll")]
        public IActionResult EnrollStudentsToCourse([FromBody] List<StudentCourse> studentCourses)
        {
            try
            {

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("course/{id}")]
        public IActionResult GetStudentsInCourse(int id)
        {
            try
            {

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("course/{courseId}/student/{studentId}")]
        public IActionResult RemoveStudentFromCourse(int courseId, int studentId)
        {
            try
            {

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
