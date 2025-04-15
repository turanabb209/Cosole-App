using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementApp
{
  public class Group
    {  
        public string GroupName { get; set; }
        public string No { get; set; }
        public Category Category { get; set; }
        public bool IsOnline { get; set; }
        public int Limit
        {
            get
            {
                if (IsOnline)
                {
                    return 15;
                }
                else
                {
                    return 10;
                }
            }
        }

        public List<Student> students { get; set; } = new List<Student>();

        public bool AddStudent (Student student)
        {
            if (students.Count < Limit)
            {
                students.Add(student);
                return true;
            }
            return false;
        }


    }
}
