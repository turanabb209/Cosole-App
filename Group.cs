using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementApp
{
  public class Group
    {
        public int Id { get;}
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

        public List<Student> students = new List<Student>();

    }
}
