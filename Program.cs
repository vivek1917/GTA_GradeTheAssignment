namespace Project
{
    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Assignment assignment = new Assignment(1, "Math Homework", "Solve the given problems", DateTime.Now.AddDays(7));
            Teacher teacher = new Teacher(101, "John Doe", "Mathematics");
            Student student = new Student(201, "Alice Smith", "B.Sc Math", "Semester 1", "Mathematics");
            AssignmentSubmission submission = new AssignmentSubmission(1, assignment.AssignmentDueDateTime);
            AssignmentResult result = new AssignmentResult("Pass", 9.5);
            TeacherSubject teacherSubject = new TeacherSubject(new string[] { "Mathematics" }, "MTH101", new Assignment[] { assignment });

            teacher.Login();
            teacher.AddAssignment(assignment);
            student.ViewAssignment(assignment);
            submission.SubmitAssignment("source code content", "execution image path");
            teacher.Logout();
        }
    }
}
