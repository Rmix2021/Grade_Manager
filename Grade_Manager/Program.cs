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
                Console.WriteLine("8. Clear all stored grades.");
                Console.WriteLine("9. Exit");

                string choice = Console.ReadLine();
                

                switch (choice)
                {
                    case "1": ViewGrades();
                        {
                            break;
                        }

                    case "2":
                        {
                            break;
                        }

                    case "3": Add_Grade();
                        {
                            break;
                        }

                    case "4":
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

                    case "9":
                        {
                            break;
                        }

                    default:
                        Console.WriteLine("PLease choose a number 1-9");
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
                gradesList.ForEach(i => Console.Write("{0}\t", i));
                Console.WriteLine("");
                Menu();
            }
        }
    }
}
