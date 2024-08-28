using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    // TeacherSubject class
    public class TeacherSubject
    {
        public string[] SubjectNames { get; set; }
        public string SubjectCode { get; set; }
        public Assignment[] SubjectAssignments { get; set; }

        public TeacherSubject(string[] subjectNames, string code, Assignment[] assignments)
        {
            SubjectNames = subjectNames;
            SubjectCode = code;
            SubjectAssignments = assignments;
        }
    }
}
