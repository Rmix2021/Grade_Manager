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
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "*********Grade Manager Ver 2.0*********"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Keep track of your Classrooms,         "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Students and all grades                "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "1. Show ClassRooms.                    "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "2. Add a ClassRoom.                    "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "3. Remove a ClassRoom.                 "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "4. ClassRoom Details Menu.             "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "9. Exit App.                           "));

            Console.SetCursorPosition(21, 9);
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
                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"Classroom Name: {kvp.Value.name}                                          "));

                }
            }

            static void ShowClassRooms()
            {
                Console.Clear();
                WriteLineClassRoomDictionary();
                Console.ReadLine();
                Menu();
            }

            static void AddClassRoom()
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Name the classroom in which you would like to add."));
                Console.SetCursorPosition(21, 9);
                string classRoomName = Console.ReadLine().ToUpper();
                classRoomsDictionary.Add(classRoomName, new ClassRoom(classRoomName));
                Menu();


            }

            static void ClassRoomDetailsSubMenu()
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Type the ClassRoom name in which you would like edit"));
                WriteLineClassRoomDictionary();
                string classroomChoice = Console.ReadLine().ToUpper();
                classRoomsDictionary[classroomChoice].ClassRoomDetailsMenu();
            }

            static void RemoveClassRoom()
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Type the ClassRoom name in which you would like to remove."));
                Console.SetCursorPosition(21, 9);
                string classRoomName = Console.ReadLine().ToUpper();
                classRoomsDictionary.Remove(classRoomName);
                Menu();
            }

            static void Exit()
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Exit? Press 9 again"));
                Console.SetCursorPosition(20, 20);
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



