using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grade_Manager_OO
{
    public class MainMenu
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        public static Dictionary<string, ClassRoom> classRoomsDictionary = new Dictionary<string, ClassRoom>();
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine(
            @"*********Grade Manager Ver 2.0*********
Keep track of your Classrooms
Students and all grades
1. Show ClassRooms.
2. Add a ClassRoom.                  
3. Remove a ClassRoom.                 
4. ClassRoom Details Menu.           
9. Exit App.");
           
            string classRoomChoice = Console.ReadLine().ToUpper();


            switch (classRoomChoice)
            {
                case "1":
                    ShowClassRooms();
                    {
                        break;
                    }

                case "2":
                    AddClassRoom();
                    {
                        break;
                    }

                case "3":
                    RemoveClassRoom();
                    {
                        break;
                    }

                case "4":
                    ClassRoomDetailsSubMenu();
                    {
                        break;
                    }

                case "9":
                    Exit();

                    {
                        break;
                    }
            }

            static void WriteLineClassRoomDictionary()
            {
                foreach (KeyValuePair<string, ClassRoom> kvp in classRoomsDictionary)
                {
                    Console.WriteLine($"Classroom Name:" + kvp.Value.name);
                }
            }

            static void ShowClassRooms()
            {
                Console.Clear();
                WriteLineClassRoomDictionary();
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                Menu();
            }

            static void AddClassRoom()
            {
                Console.Clear();
                Console.WriteLine("Name the classroom in which you would like to add.");
                
                string classRoomName = Console.ReadLine().ToUpper();
                classRoomsDictionary.Add(classRoomName, new ClassRoom(classRoomName));
                Menu();


            }

            static void ClassRoomDetailsSubMenu()
            {
                Console.Clear();
                Console.WriteLine("Type the ClassRoom name in which you would like edit");
                WriteLineClassRoomDictionary();
                string classroomChoice = Console.ReadLine().ToUpper();
                classRoomsDictionary[classroomChoice].ClassRoomDetailsMenu();
            }

            static void RemoveClassRoom()
            {
                Console.Clear();
                Console.WriteLine("Type the ClassRoom name in which you would like to remove.");
                WriteLineClassRoomDictionary();
                string classRoomName = Console.ReadLine().ToUpper();
                classRoomsDictionary.Remove(classRoomName);
                Menu();
            }

            static void Exit()
            {
                Console.Clear();
                Console.WriteLine("Exit? Press 9 again");
                
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer != 9)
                {
                    Menu();
                }
                Environment.Exit(9);
            }
        }

    }
}



