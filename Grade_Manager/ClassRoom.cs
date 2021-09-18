﻿using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;
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
                Console.WriteLine($"Student Name:" + kvp.Value.StudentName);
                Console.WriteLine($"Students Average:" + kvp.Value.Average);
                Console.WriteLine($"Students Completion Status:" + kvp.Value.AllAssignmentsCompleteTrueOrFalse);
            }
        }

        public void ClassRoomDetailsMenu()
        {
            Console.Clear();
            Console.WriteLine("*********Edit Classrooms Menu**********");
            Console.WriteLine("Currently Editing " + this.name + " Class");
            Console.WriteLine(@"1. Show Students.               
2. Add Student.                        
3. Remove Student.
4. Student Details Menu.             
5. Show class average.                 
6. Show top student.                  
7. Show worst student.                 
8. Compare 2 students.                
9. Exit this menu.");           

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
                if (studentDictionary == null)
                {
                    ClassRoomDetailsMenu();
                }
                else
                {
                    WriteLineStudentDictionary();
                    Console.WriteLine("Press enter to continue.");                
                    Console.ReadLine();
                    ClassRoomDetailsMenu();
                }
            }

            void AddStudent()
            {
                Console.Clear();
                Console.WriteLine("Name the Student in which you would like to add.");                
                string studentName = Console.ReadLine().ToUpper();
                studentDictionary.Add(studentName, new Student(studentName));
                ClassRoomDetailsMenu();
            }

            void StudentDetailsMenu()
            {
                Console.Clear();
                if(studentDictionary == null)
                {
                    ClassRoomDetailsMenu();
                }
                else
                {
                    Console.WriteLine("Type the Student name in which you would like edit");
                    WriteLineStudentDictionary();
                    string studentChoice = Console.ReadLine().ToUpper();
                    if(studentDictionary.ContainsKey(studentChoice) != true)
                    {
                        ClassRoomDetailsMenu();
                    }
                    else
                    {
                        studentDictionary[studentChoice].EditStudentDetailsMenu();
                    }
                }
            }

            void RemoveStudent()
            {
                Console.Clear();
                if(studentDictionary == null)
                {
                    ClassRoomDetailsMenu();
                }
                else
                {
                    Console.WriteLine("Type the Student name in which you would like to remove.");
                    WriteLineStudentDictionary();
                    string studentName = Console.ReadLine().ToUpper();
                    if (studentDictionary.ContainsKey(studentName))
                    {
                        ClassRoomDetailsMenu();
                    }
                    else
                    {
                        studentDictionary.Remove(studentName);
                    }

                }
            }

            void ShowClassAverage()
            {
                Console.Clear();
                combineGradesList();
                double averagedOutClassGrades = classGradesListToAverageOut.Average();
                Console.WriteLine("The current class average is" + averagedOutClassGrades);
                Console.WriteLine("Press enter to continue.");                
                Console.ReadLine();
                ClassRoomDetailsMenu();
            }

            void ShowTopStudent()
            {
                Console.Clear();
                var max = studentDictionary.Max(average => average.Value);
                if(studentDictionary == null)
                {
                    Console.WriteLine("There are no students yet.");
                    Console.WriteLine("Press enter to continue.");
                    ClassRoomDetailsMenu();
                }
                else
                {
                    Console.WriteLine("This is your best current student.");
                    Console.WriteLine(max.StudentName);               
                    Console.WriteLine("Press enter to continue.");                
                    Console.ReadLine();
                    ClassRoomDetailsMenu();
                }
            }

            void ShowBottomStudent()
            {
                Console.Clear();
                var min = studentDictionary.Min(average => average.Value);
                if(studentDictionary == null)
                {
                    Console.WriteLine("There are no students yet.");
                    Console.WriteLine("Press enter to continue.");
                    ClassRoomDetailsMenu();
                }
                else
                {
                    Console.WriteLine("This is your best current student.");
                    Console.WriteLine(min.StudentName);
                    Console.WriteLine("Press enter to continue.");                
                    Console.ReadLine();
                    ClassRoomDetailsMenu();
                }
            }

            void Compare2Student()
            {
                Console.Clear();
                Console.WriteLine("Choose the 2 students you wish to compare.");
                WriteLineStudentDictionary();
                Console.WriteLine("Student 1.");                
                string student1 = Console.ReadLine().ToUpper();
                Console.WriteLine("Student 2.");
                string student2 = Console.ReadLine().ToUpper();

                if (studentDictionary.ContainsKey(student1) && studentDictionary.ContainsKey(student2))
                {
                    Console.WriteLine("Student 1: " + studentDictionary[student1]);
                    Console.WriteLine("");
                    Console.WriteLine("Student 2: " + studentDictionary[student2]);
                    Console.WriteLine("");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                    ClassRoomDetailsMenu();
                }
                else
                {
                    ClassRoomDetailsMenu();
                }



                Console.WriteLine("Student 1 details:");
                Console.WriteLine($"Student Name:" );
                Console.WriteLine($"Students Average:");
                Console.WriteLine($"Students Completion Status:");

                Console.WriteLine("Student 2 details:");



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

