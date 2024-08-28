using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public string AssignmentName { get; set; }
        public string AssignmentDescription { get; set; }
        public DateTime AssignmentDueDateTime { get; set; }

        public Assignment(int id, string name, string description, DateTime dueDateTime)
        {
            AssignmentId = id;
            AssignmentName = name;
            AssignmentDescription = description;
            AssignmentDueDateTime = dueDateTime;
        }
    }
}
