using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Manager_OO
{
    public class ClassRoom
    {
        public string name { get; set; }

        public Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();

        public List<double> classGradesListToAverageOut = new List<double>();

        public ClassRoom(string classRoomName)
        {
            this.name = classRoomName.ToUpper();
        }

        void WriteLineStudentDictionary()
        {
            foreach (KeyValuePair<string, Student> kvp in this.studentDictionary)
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"Student Name: {kvp.Value.StudentName}                                          "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"Students Average: {kvp.Value.Average}                                          "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"Students Completion Status: {kvp.Value.AllAssignmentsCompleteTrueOrFalse} +  /n"));
            }
        }

        public void ClassRoomDetailsMenu()
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "*********Edit Classrooms Menu**********"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Currently Editing 'classroom xyz'      "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "1. Show Students.                      "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "2. Add Student.                        "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "3. Remove Student.                     "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "4. Student Details Menu.               "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "5. Show class average.                 "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "6. Show top student.                   "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "7. Show worst student.                 "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "8. Compare 2 students.                 "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "9. Exit this menu.                     "));
            Console.SetCursorPosition(21, 12);

            string classRoomChoice = Console.ReadLine().ToUpper();

            switch (classRoomChoice)
            {
                case "1":
                    ShowStudents();
                    {
                        break;
                    }

                case "2":
                    AddStudent();
                    {
                        break;
                    }

                case "3":
                    RemoveStudent();
                    {
                        break;
                    }

                case "4":
                    StudentDetailsMenu();
                    {
                        break;
                    }

                case "5":
                    ShowClassAverage();
                    {
                        break;
                    }

                case "6":
                    ShowTopStudent();
                    {
                        break;
                    }

                case "7":
                    ShowBottomStudent();
                    {
                        break;
                    }

                case "8":
                    Compare2Student();
                    {
                        break;
                    }
                case "9":
                    ExitThisMenu();
                    {
                        break;
                    }
            }

            void ShowStudents()
            {
                Console.Clear();
                WriteLineStudentDictionary();
                Console.ReadLine().ToUpper();
                ClassRoomDetailsMenu();
            }

            void AddStudent()
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Name the Student in which you would like to add."));
                Console.SetCursorPosition(21, 9);
                string studentName = Console.ReadLine().ToUpper();
                studentDictionary.Add(studentName, new Student(studentName));
                Console.ReadLine();
                ClassRoomDetailsMenu();
            }

            void StudentDetailsMenu()
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Type the Student name in which you would like edit"));
                WriteLineStudentDictionary();
                string studentChoice = Console.ReadLine().ToUpper();
                studentDictionary[studentChoice].EditStudentDetailsMenu();
            }

            void RemoveStudent()
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Type the Student name in which you would like to remove."));
                Console.SetCursorPosition(21, 9);
                string studentName = Console.ReadLine().ToUpper();
                studentDictionary.Remove(studentName);
                ClassRoomDetailsMenu();
            }

            void ShowClassAverage()
            {
                Console.Clear();
                combineGradesList();
                classGradesListToAverageOut.Average();
                Console.ReadLine();
                ClassRoomDetailsMenu();
            }

            void ShowTopStudent()
            {
                Console.Clear();
                Console.ReadLine();
                ClassRoomDetailsMenu();
            }

            void ShowBottomStudent()
            {
                Console.Clear();
                Console.ReadLine();
                ClassRoomDetailsMenu();
            }

            void Compare2Student()
            {
                Console.Clear();
                Console.ReadLine();
                ClassRoomDetailsMenu();
            }

            void ExitThisMenu()
            {
                Console.Clear();
                MainMenu.Menu();
            }

            void combineGradesList()
            {
                foreach (KeyValuePair<string, Student> kvp in this.studentDictionary)
                {
                    classGradesListToAverageOut.AddRange(kvp.Value.gradesListToAverageOut);
                }

            }

        }
    }
}

