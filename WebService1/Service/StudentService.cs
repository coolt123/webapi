using WebService1.Entity;

namespace WebService1.Service
{
    public class StudentService : IStudentService
    {
        private readonly List<Student> _students = new List<Student>();

        public Student AddStudent(Student student)
        {
            // Validate student object
            if (student == null)
                throw new ArgumentNullException(nameof(student));

            if (_students.Any(s => s.Id == student.Id))
                throw new InvalidOperationException("Student with the same ID already exists.");

            _students.Add(student);
            return student;
        }

        public void UpdateStudent(int id, Student student)
        {
            // Validate student object
            if (student == null)
                throw new ArgumentNullException(nameof(student));

            var existingStudent = _students.FirstOrDefault(s => s.Id == id);
            if (existingStudent == null)
                throw new KeyNotFoundException("Student not found.");

            existingStudent.Name = student.Name;
            existingStudent.StudentCode = student.StudentCode;
            existingStudent.DateOfBirth = student.DateOfBirth;
        }

        public Student GetStudentById(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                throw new KeyNotFoundException("Student not found.");
            return student;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _students;
        }

        public void DeleteStudent(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                throw new KeyNotFoundException("Student not found.");

            _students.Remove(student);
        }
    }
}
