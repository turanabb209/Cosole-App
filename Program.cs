using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

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
                   //Console.WriteLine("Limit:");
                    //int limit = Convert.ToInt32(Console.ReadLine());                   
                    case "1":
                        int categoryNum;
                        Console.WriteLine("Category:");
                        Console.WriteLine("*Qeyd* Category olaraq bunlardan birini sece bilersiniz:\nProgramming, Design, SystemAdministration");
                        int.TryParse(Console.ReadLine(), out categoryNum);
                        Category category = (Category)categoryNum;
                        //if (!Enum.TryParse(categoryNum, true, out category))
                        //{
                        //    Console.WriteLine("Yanlış kateqoriya daxil edildi. Zehmet olmasa yeniden cehd edin");
                        //    return;
                        //}

                        Console.WriteLine("Qrup online-dirmi?\n *Qeyd:beli/xeyr secerek cavablandirin zehmet olmasa;");
                        string isOnlineStr = Console.ReadLine().ToLower();
                        bool isOnline = isOnlineStr == "beli";
                        Console.WriteLine("Qrupun limitini daxil edin:");
                        if (!int.TryParse(Console.ReadLine(), out int limit))
                        {
                            Console.WriteLine("Limit düzgün formatda deyil.");
                            return;
                        }
                        //Console.WriteLine("Limit:");
                        //int limit1 = Convert.ToInt32(Console.ReadLine());

                     
                        Group newGroup = new Group()
                        {
                            Category = category,
                            IsOnline = isOnline,
                        
                        };                    
                        Helper.CreateGroup(groups, newGroup);
                        break;

                    case "2":

                        Helper.ShowGroupList(groups);

                        break;
                    case "3":
                        Console.WriteLine("Düzəliş etmək istədiyiniz GroupNo-ni daxil edin:");
                        string groupNo = Console.ReadLine();

                      
                        Helper.EditGroup(groups);


                        break;
                    case "4":

                        Helper.ShowStudentList(groups, students);

                        break;
                    case "5":

                        Helper.ShowAllStudentList(students);

                        break;

                    case "6":

                        Console.WriteLine("Name");
                        string name = Console.ReadLine();

                        Console.WriteLine(" Surname");
                        string surname = Console.ReadLine();
                        
                        Console.WriteLine("Group adi daxil edin:");
                        string groupName = Console.ReadLine();

                        Group group = new Group
                        {
                            GroupName = groupName
                        };

                        Console.WriteLine("GroupNo:");
                        string groupNo1 = Console.ReadLine();

                        Student student1 = new Student()
                        {
                            Name = name,
                            Surname = surname,
                            Group = group,
                            GroupNo = groupNo1

                        };
                        Console.WriteLine("Tələbə type-nı daxil edin (1 - Zəmanətli, 2 - Zəmanətsiz):");
                        string typeStr = Console.ReadLine();
                        int typeNum;
                        if (!int.TryParse(typeStr, out typeNum) || !Enum.IsDefined(typeof(Type), typeNum))
                        {
                            Console.WriteLine("Yanlış tələbə type-ı daxil edildi.");
                            return;
                        }
                        Type studentType = (Type)typeNum;
                        Helper.CreateStudent(students, student1);
                        break;
                }
                
            } while (Input != "0");

            Console.WriteLine("Program exited successfully!");
        }
    }
}














