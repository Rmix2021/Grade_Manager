using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> gradesList = new List<double>();
            Menu();

            void Menu()
            {
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "**********   Grade Manager  **********  "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Keep track of your grades.              "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "1. View currently stored grades.        "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "2. View class grade average.            "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "3. Add a grade.                         "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "4. Edit a grade.                        "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "5. Remove a student.                    "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "6. View top student.                    "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "7. View bottom student.                 "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "8. Clear all stored students and grades."));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "9. Exit                                 "));

                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        ViewGrades();
                        {
                            break;
                        }

                    case "2":
                        ClassAverage();
                        {
                            break;
                        }

                    case "3":
                        Add_Grade();
                        {
                            break;
                        }

                    case "4":
                        Edit_Grade();
                        {
                            break;
                        }

                    case "5": RemoveStudent();
                        {
                            break;
                        }

                    case "6": ViewTopStudent();
                        {
                            break; 
                        }

                    case "7": ViewBottomStudent();
                        {
                            break;
                        }

                    case "8": ClearAllValues();
                        {
                            break;
                        }

                    case "9": Exit();
                        {
                            break;
                        }

                    default:
                        Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "PLease choose a number 1-9      "));
                        Console.WriteLine("");
                        Menu();
                        break;

                }


            }


            void Add_Grade()
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Enter a grade 1-100                     "));
                double gradeToBeAdded = Convert.ToDouble(Console.ReadLine());
                gradesList.Add(gradeToBeAdded);
                Console.WriteLine("");
                Menu();
            }

            void ViewGrades()
            {
                Console.Clear();
                if (gradesList.Count == 0)
                {
                    throw new InvalidOperationException("Empty list");
                    
                }

                for (int i = 0; i < gradesList.Count; i++)
                {
                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"{i} = {gradesList[i]}              "));
                    Console.WriteLine("");
                }

                Menu();

            }

            void Edit_Grade()
            {
                Console.Clear();
                for (int i = 0; i < gradesList.Count; i++)
                {
                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"{i} = {gradesList[i]}              "));
                    Console.WriteLine("");
                }
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Choose a position to edit (ie 0,1,2...etc)"));
                int choiceToEdit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Replace with new grade.                   "));
                Console.WriteLine("");

                double editChoiceWith = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");

                gradesList.RemoveAt(choiceToEdit);
                gradesList.Insert(choiceToEdit, editChoiceWith);

                Console.WriteLine("");

                Menu();
            }

            void ClassAverage()
            {
            Console.Clear();
            double classAverage = gradesList.Average();

            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "The class average grade is" + " " + classAverage));           
            Console.WriteLine("");
            Menu();
            }

            void Exit()
            {
                Console.Clear();
                Environment.Exit(9);
            }

            void ClearAllValues()
            {
                Console.Clear();
                gradesList.Clear();
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "******CLEARED*****                        "));
                Menu();
            }

            void RemoveStudent()
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Choose the student you wish to remove from class"));
                Console.WriteLine("");

                for (int i = 0; i < gradesList.Count; i++)
                {
                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"{i} = {gradesList[i]}                "));
                    Console.WriteLine("");
                }

                int choiceToRemove = Convert.ToInt32(Console.ReadLine());
                gradesList.RemoveAt(choiceToRemove);
                ViewGrades();

            }

            void ViewTopStudent()
            {
                Console.Clear();
                               
                gradesList.Sort();
                
                if (gradesList.Count == 0)
                {
                    throw new InvalidOperationException("Empty list");

                }                
                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"{gradesList.Count-1}  = {gradesList[gradesList.Count-1]}             "));
                    Console.WriteLine("");
                Menu();
            }

            void ViewBottomStudent()
            {
                Console.Clear();
                gradesList.Sort();
                if (gradesList.Count == 0)
                {
                    throw new InvalidOperationException("Empty list");

                }
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"{0}  = {gradesList[0]}             "));
                Console.WriteLine("");
                Menu();
            }

        }

    }
}
