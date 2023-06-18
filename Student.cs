using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_scope
{
    internal class Student : person
    {
        string StudentID;
        string StudentMajor;

        public Student(string name, int age, string StudentID, string StudentMajor) 
        {
            this.StudentID = name;
            this.StudentMajor = StudentMajor;
        }
    }
    
}
