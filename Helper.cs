using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementApp
{
  public static  class Helper
    { //-------------------------------------------------------METODLAR------------------------------------------------------------------------------

        public static void  CreateGroup(List<Group> groups, Group group)
        {
            Console.WriteLine("Yaratmaq istediyiniz qrupun adini daxil edin:");
            string groupNo = Console.ReadLine();

      
            if (groups.Exists(g => g.No == groupNo))
            {
                Console.WriteLine("Bu qrup artıq mövcuddur, zəhmət olmasa yenidən cəhd edin.");
                return;
            }

      
            group.No = groupNo;
            groups.Add(group);
            Console.WriteLine("Qrup uğurla yaradıldı.");
        }


        public static void ShowGroupList(List<Group> groups)
        {
            foreach (var item in groups)
            {
                Console.WriteLine($"Category:{item.Category}, Group is Online:{item.IsOnline}, Limit:{item.Limit}");
            }
        }

        public static void EditGroup(List<Group> groups)
        {
            Console.WriteLine("Duzelis etmek istediyiniz GroupNo daxil edin:");
            string groupNo = Console.ReadLine();

            Group existGroup = groups.FirstOrDefault(g => g.No == groupNo);
            if (existGroup == null)
            {
                Console.WriteLine("Bele bir qrup tapilmadi");
                return;
            }

            Console.WriteLine("Yeni GroupNo daxil edin:");
            string newGroupNo = Console.ReadLine();

            if (groups.Any(g => g.No == newGroupNo))
            {
                Console.WriteLine("Bu adda qrup artıq mövcuddur.");
                return;
            }

            existGroup.No = newGroupNo;
            Console.WriteLine("Group uğurla yeniləndi.");

        }


        public static void ShowStudentList(List<Group> groups, List<Student> students)
        {
            Console.WriteLine("Baxmaq istediyiniz GroupNo daxil edin:");
            string groupNo = Console.ReadLine();

            foreach (var student in students)
            {
                Console.WriteLine($"Name:{student.Name}, Surname:{student.Surname}, GroupNo:{student.GroupNo}");
            }

            Group group = groups.FirstOrDefault(g => g.No == groupNo);
            if (group == null)
            {
                Console.WriteLine("Bele bir qrup movcud deyil");
                return;
            }


            if (students.Count == 0)
            {
                Console.WriteLine("Bu qrupda telebe yoxdur");
                return;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Name:{student.Name}, Surname:{student.Surname}, Group:{student.Group}, GroupNo:{student.GroupNo}");
            }

        }

        public static void ShowAllStudentList(List<Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine($"Name:{item.Name}, Surname:{item.Surname}, Group:{item.Group}, GroupNo:{item.GroupNo}");
            }
        }
        public static void CreateStudent(List<Student> students, Student student)
        {
            students.Add(student);
        }

    }
}
