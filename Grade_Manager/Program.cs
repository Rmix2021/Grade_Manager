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
                Console.WriteLine("****** Grade Manager *******");
                Console.WriteLine("Keep track of your grades.");
                Console.WriteLine("1. View currently stored grades.");
                Console.WriteLine("2. View class grade average.");
                Console.WriteLine("3. Add a grade.");
                Console.WriteLine("4. Edit a grade.");
                Console.WriteLine("5. Remove a student.");
                Console.WriteLine("6. View top student.");
                Console.WriteLine("7. View bottom student.");
                Console.WriteLine("8. Clear all stored students and grades.");
                Console.WriteLine("9. Exit");

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

                    case "5":
                        {
                            break;
                        }

                    case "6":
                        {
                            break;
                        }

                    case "7":
                        {
                            break;
                        }

                    case "8":
                        {
                            break;
                        }

                    case "9": Exit();
                        {
                            break;
                        }

                    default:
                        Console.WriteLine("PLease choose a number 1-9");
                        Console.WriteLine("");
                        Menu();
                        break;

                }


            }


            void Add_Grade()
            {
                Console.WriteLine("Enter a grade 1-100");
                double gradeToBeAdded = Convert.ToDouble(Console.ReadLine());
                gradesList.Add(gradeToBeAdded);
                Console.WriteLine("");
                Menu();
            }

            void ViewGrades()
            {
                for (int i = 0; i < gradesList.Count; i++)
                {
                    Console.WriteLine($"{i} = {gradesList[i]}");
                    Console.WriteLine("");
                }

                Menu();

            }

            void Edit_Grade()
            {
                for (int i = 0; i < gradesList.Count; i++)
                {
                    Console.WriteLine($"{i} = {gradesList[i]}");
                    Console.WriteLine("");
                }
                Console.WriteLine("Choose a position to edit (ie 0,1,2...etc)");
                int choiceToEdit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Replace with new grade.");
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
            double classAverage = gradesList.Average();
            Console.WriteLine("The class average grade is" + " " + classAverage);
            Console.WriteLine("");
            Menu();
            }

            void Exit()
            {
                Environment.Exit(9);
            }
        }

    }
}
