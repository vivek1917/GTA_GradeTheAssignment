using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    // AssignmentResult class
    public class AssignmentResult
    {
        public string Status { get; set; }
        public double Marks { get; set; }

        public AssignmentResult(string status, double marks)
        {
            Status = status;
            Marks = marks;
        }
    }
}
