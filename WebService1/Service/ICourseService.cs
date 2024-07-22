using WebService1.Entity;

namespace WebService1.Service
{
    public interface ICourseService
    {
        Course AddCourse(Course course);
        void UpdateCourse(int id, Course course);
        Course GetCourseById(int id);
        IEnumerable<Course> GetAllCourses();
        void DeleteCourse(int id);
    }
}
