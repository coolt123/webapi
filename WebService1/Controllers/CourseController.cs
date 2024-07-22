using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebService1.Entity;
using WebService1.Service;


namespace WebService1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult AddCourse([FromBody] Course course)
        {
            try
            {
                var addedCourse = _courseService.AddCourse(course);
                return Ok(addedCourse);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCourse(int id, [FromBody] Course course)
        {
            try
            {
                _courseService.UpdateCourse(id, course);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetCourseById(int id)
        {
            try
            {
                var course = _courseService.GetCourseById(id);
                return Ok(course);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAllCourses()
        {
            try
            {
                var courses = _courseService.GetAllCourses();
                return Ok(courses);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(int id)
        {
            try
            {
                _courseService.DeleteCourse(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
