using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherDepartment { get; set; }

        public Teacher(int id, string name, string department)
        {
            TeacherId = id;
            TeacherName = name;
            TeacherDepartment = department;
        }

        public void Login()
        {
            Console.WriteLine($"{TeacherName} logged in.");
        }

        public void Logout()
        {
            Console.WriteLine($"{TeacherName} logged out.");
        }

        public void AddAssignment(Assignment assignment)
        {
            Console.WriteLine($"Assignment '{assignment.AssignmentName}' added by {TeacherName}.");
        }

        public void RemoveAssignment(int assignmentId)
        {
            Console.WriteLine($"Assignment with ID {assignmentId} removed by {TeacherName}.");
        }
    }
}
