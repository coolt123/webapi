using WebService1.Entity;

namespace WebService1.Service
{

    namespace APINetCore.Service
    {
        public class CourseService : ICourseService
        {
            private readonly List<Course> _courses = new List<Course>();
            public Course AddCourse(Course course)
            {
                if (course == null)
                    throw new ArgumentNullException(nameof(course));

                if (_courses.Any(c => c.Id == course.Id))
                    throw new InvalidOperationException("Course with the same ID already exists.");

                _courses.Add(course);
                return course;
            }
            public void UpdateCourse(int id, Course course)
            {
                // Validate course object
                if (course == null)
                    throw new ArgumentNullException(nameof(course));

                var existingCourse = _courses.FirstOrDefault(c => c.Id == id);
                if (existingCourse == null)
                    throw new KeyNotFoundException("Course not found.");

                existingCourse.Name = course.Name;
                existingCourse.CourseCode = course.CourseCode;
                existingCourse.MaxStudents = course.MaxStudents;
            }

            public Course GetCourseById(int id)
            {
                var course = _courses.FirstOrDefault(c => c.Id == id);
                if (course == null)
                    throw new KeyNotFoundException("Course not found.");
                return course;
            }

            public IEnumerable<Course> GetAllCourses()
            {
                return _courses;
            }

            public void DeleteCourse(int id)
            {
                var course = _courses.FirstOrDefault(c => c.Id == id);
                if (course == null)
                    throw new KeyNotFoundException("Course not found.");

                _courses.Remove(course);
            }
        }
    }
}
