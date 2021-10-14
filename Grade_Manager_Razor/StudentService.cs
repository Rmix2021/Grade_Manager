using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grade_Manager_Razor.Data;
using Grade_Manager_Razor.Models;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor
{
    public class StudentService
    {

        readonly GradeManagerDbContext _context;
        readonly ILogger _logger;

        public StudentService(GradeManagerDbContext context, ILoggerFactory factory)
        {
            this._context = context;
            _logger = factory.CreateLogger<StudentService>();
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            var studentList = _context.Students;
            foreach (var student in studentList)
            {
                students.Add(student);

            }
            return students;

        }

        public List<Student> GetFilteredStudents(int id)
        {
            List<Student> students = new List<Student>();

            var studentList = _context.Students
                .Where(x => x.ClassRoomId == id);
            foreach (var student in studentList)
            {
                students.Add(student);
            }
            return students;

        }

        public Student AddNewStudent(AddStudentViewModel name)
        {
            var student = name.ToStudent();            
            _context.Add(student);
            _context.SaveChanges();
            return student;
        }

        public Student GetFilteredStudentToDelete(int StudentId)
        {
            return this._context.Students.Where(x => x.StudentId == StudentId).FirstOrDefault();
        }

        public Student GetAStudentById(int id)
        {
            return this._context.Students.Where(x => x.StudentId == id).FirstOrDefault();

        }

     

    }
}

