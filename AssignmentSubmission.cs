using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    // AssignmentSubmission class
    public class AssignmentSubmission
    {
        public int AssignmentId { get; set; }
        public DateTime AssignmentDueDateTime { get; set; }

        public AssignmentSubmission(int id, DateTime dueDateTime)
        {
            AssignmentId = id;
            AssignmentDueDateTime = dueDateTime;
        }

        public bool ValidateAssignment(string sourceCode, string executionImage)
        {
            Console.WriteLine("Validating assignment...");
            return true;
        }

        public void SubmitAssignment(string sourceCode, string executionImage)
        {
            Console.WriteLine("Assignment submitted.");
        }

        public void CheckAssignment()
        {
            Console.WriteLine("Checking assignment...");
        }
    }
}
