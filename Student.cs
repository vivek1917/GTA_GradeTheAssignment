using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    // Student class
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Course { get; set; }
        public string Semester { get; set; }
        public string StudentDepartment { get; set; }

        public Student(int id, string name, string course, string semester, string department)
        {
            StudentId = id;
            StudentName = name;
            Course = course;
            Semester = semester;
            StudentDepartment = department;
        }

        public void Login()
        {
            Console.WriteLine($"{StudentName} logged in.");
        }

        public void Logout()
        {
            Console.WriteLine($"{StudentName} logged out.");
        }

        public void ViewAssignment(Assignment assignment)
        {
            Console.WriteLine($"Viewing assignment '{assignment.AssignmentName}'");
        }
    }
}
