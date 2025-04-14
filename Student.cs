using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementApp
{
   public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Group Group { get; set; }
        public string GroupNo { get; set; }
        public Type Type { get; set; }
    }
}
