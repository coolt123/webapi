using WebService1.Entity;

namespace WebService1.Service
{
    public interface IStudentService
    {
        Student AddStudent(Student student);
        void UpdateStudent(int id, Student student);
        Student GetStudentById(int id);
        IEnumerable<Student> GetAllStudents();
        void DeleteStudent(int id);
    }
}
