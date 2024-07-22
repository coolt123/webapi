using WebService1.Entity;

namespace WebService1.Service
{
    public class StudentCourseService : IStudentCourseService
    {
        private readonly List<StudentCourse> _studentCourses;
        private readonly List<Student> _students;

        public StudentCourseService()
        {
            _studentCourses = new List<StudentCourse>();
            _students = new List<Student>();
        }

        public void EnrollStudentsToCourse(List<StudentCourse> studentCourses)
        {
            if (studentCourses == null || studentCourses.Count == 0)
                throw new ArgumentException("Student courses cannot be null or empty.");

            foreach (var studentCourse in studentCourses)
            {
                // Validate if student and course exist
                if (!_students.Any(s => s.Id == studentCourse.StudentId))
                    throw new ArgumentException($"Student with ID {studentCourse.StudentId} does not exist.");

                // Add student to course
                _studentCourses.Add(studentCourse);
            }
        }

        public IEnumerable<Student> GetStudentsInCourse(int courseId)
        {
            var studentsInCourse = _studentCourses
                .Where(sc => sc.CourseId == courseId)
                .Join(_students, sc => sc.StudentId, s => s.Id, (sc, s) => s)
                .ToList();

            return studentsInCourse;
        }

        public void RemoveStudentFromCourse(int courseId, int studentId)
        {
            var studentCourse = _studentCourses.FirstOrDefault(sc => sc.CourseId == courseId && sc.StudentId == studentId);
            if (studentCourse == null)
                throw new KeyNotFoundException("Student not enrolled in the course.");

            _studentCourses.Remove(studentCourse);
        }
    }
}
