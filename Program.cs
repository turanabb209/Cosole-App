using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.Serialization;

namespace CourseManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();
            List<Student> students = new List<Student>();



            string Input;
            do
            {

                Console.WriteLine("1. Yeni qrup yaradın");
                Console.WriteLine("2. Qrupların siyahısını göstər");
                Console.WriteLine("3. Qrup üzərində düzəliş etmək");
                Console.WriteLine("4. Qrupdakı tələbələrin siyahısını göstər");
                Console.WriteLine("5. Bütün tələbələrin siyahısını göstər");
                Console.WriteLine("6. Tələbə yarat");

                Input = Console.ReadLine();

                switch (Input)
                {
                    case "1":
                        int categoryNum;
                        Console.WriteLine("Category:");
                        int.TryParse(Console.ReadLine(), out categoryNum);
                        Category category = (Category)categoryNum;
                      
                        Console.WriteLine(" Group is Online:");
                        bool Isonline = Convert.ToBoolean(Console.ReadLine());
                      
                        Console.WriteLine("Limit:");
                        int limit = Convert.ToInt32(Console.ReadLine());

                        Group Group = new Group()
                        {
                            Category = category,
                            IsOnline = Isonline,                          
                        };


                        CreateGroup(groups, Group);


                        break;
                    case "2":

                        ShowGroupList(groups);

                        break;
                    case "3":
                        Console.WriteLine("Duzelis etmek istediyiniz GroupNo daxil edin:");
                        string groupNo = Console.ReadLine();

                      
                        EditGroup();


                        break;
                    case "4":

                        ShowStudentList(groups, students);

                        break;
                    case "5":

                        ShowAllStudentList(students);

                        break;

                    case "6":

                        Console.WriteLine("Name");
                        string name = Console.ReadLine();

                        Console.WriteLine(" Surname");
                        string surname = Console.ReadLine();

                        
                        Console.WriteLine("Group:");
                        
                        Group group = Console.ReadLine();

                        Console.WriteLine("GroupNo:");
                        string groupNo1 = Console.ReadLine();

                        Student student1 = new Student()
                        {
                            Name = name,
                            Surname = surname,
                            Group = group,
                            GroupNo = groupNo1

                        };
                        CreateStudent(students, student1);
                        break;
                }
                
            } while (Input != "0");

            Console.WriteLine("Program exited successfully!");
        }


//-------------------------------------------------------METODLAR------------------------------------------------------------------------------










        public static void CreateGroup(List<Group> groups,Group group)
        {
            groups.Add(group);
        }
        public static void ShowGroupList(List<Group> groups)
        {
            foreach (var item in groups)
            {
                Console.WriteLine($"Category:{item.Category}, Group is Online:{item.IsOnline}, Limit:{item.Limit}");
            }
        }
        public static void EditGroup()
        {
            var existData = GetById(id);
            Console.WriteLine("New GroupNo daxil edin:");
            string newgroupNo = Console.ReadLine();
            existData.GroupNo = newgroupNo;
        }
        public static void ShowStudentList(List<Group> groups, List<Student> students)
        {
            if ( existData == GetById(id))
          {

                    foreach (var student in students)
                    {
                        Console.WriteLine($"Name:{student.Name}, Surname:{student.Surname}, Group:{student.Group}, GroupNo:{student.GroupNo}");
                    }
                
            }
            else 
            {
                Console.WriteLine("Bele bir qrup tapilmadi");
            }
        }

        private static void GetById(int id)
        {
            
        }

        public static void ShowAllStudentList(List<Student> students)
        {
            foreach(var item in students)
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
