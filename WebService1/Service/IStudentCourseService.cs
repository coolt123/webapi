using WebService1.Entity;

namespace WebService1.Service
{
    public interface IStudentCourseService
    {

        public interface IStudentCourseService
        {
            void EnrollStudentsToCourse(List<StudentCourse> studentCourses);
            List<Student> GetStudentsInCourse(int courseId);
            void RemoveStudentFromCourse(int courseId, int studentId);
        }
    }
}
