using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Manager_OO
{
    public class Student
    {
        public string StudentName { get; set; }

        public double Average { get; set; }

        public bool AllAssignmentsCompleteTrueOrFalse { get; set; } = false;

        public double HighestGrade { get; set; } = 0;

        public double LowestGrade { get; set; } = 0;

        public Dictionary<string, Assignment> assignmentsDictionary = new Dictionary<string, Assignment>();


        public Student(string namedStudent)
        {
            this.StudentName = namedStudent.ToUpper();
            this.Average = 0;
        }

        public List<double> gradesListToAverageOut = new List<double>();

        void WriteLineAssignmentDictionary()
        {
            foreach (KeyValuePair<string, Assignment> kvp in this.assignmentsDictionary)
            {
                Console.WriteLine($"Assignment Name:" + kvp.Value.Name);
                Console.WriteLine($"Assignment Grade:" + kvp.Value.Grade);
                Console.WriteLine($"Assignment Completion Status:" + kvp.Value.CompletionStatus);
                Console.WriteLine("");
            }
        }

        public void EditStudentDetailsMenu()
        {
            Console.Clear();
            Console.WriteLine("******Edit Student Details Menu********");
            Console.WriteLine("Currently Editing: " + this.StudentName);
            Console.WriteLine(@"
1. Show Student Summary.
2. Assign Student New Assignment.
3. Show Assignments.
4. Grade Assignments.
5. Show students Best Grade.
6. Show students worst Grade.
9. Exit this menu.");
            

            string StudentDetailsChoice = Console.ReadLine().ToUpper();
            switch (StudentDetailsChoice)
            {
                case "1":
                    ShowStudentSummary();
                    {
                        break;
                    }

                case "2":
                    AssignNewAssignment();
                    {
                        break;
                    }

                case "3":
                    ShowAssignments();
                    {
                        break;
                    }

                case "4":
                    GradeAssignments();
                    {
                        break;
                    }

                case "5":
                    ShowStudentBestGrade();
                    {
                        break;
                    }

                case "6":
                    ShowStudentWorstGrade();
                    {
                        break;
                    }


                case "9":
                    ExitThisMenu();
                    {
                        break;
                    }
            }

            void ExitThisMenu()
            {
                Console.Clear();
                MainMenu.Menu();
            }
        }


        void ShowStudentSummary()
        {
            Console.Clear();
            WriteLineAssignmentDictionary();
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            EditStudentDetailsMenu();

        }


        void AssignNewAssignment()
        {
            Console.Clear();
            Console.WriteLine("Name the assignment in which you would like to add.");
            string assignmentName = Console.ReadLine().ToUpper();
            assignmentsDictionary.Add(assignmentName, new Assignment(assignmentName));
            EditStudentDetailsMenu();
        }


        void ShowAssignments()
        {
            Console.Clear();
            WriteLineAssignmentDictionary();
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            EditStudentDetailsMenu();
        }


        void ShowStudentBestGrade()
        {
            Console.Clear();
            Console.WriteLine(HighestGrade);
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            EditStudentDetailsMenu();
        }


        void ShowStudentWorstGrade()
        {
            Console.Clear();
            Console.WriteLine(LowestGrade);
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            EditStudentDetailsMenu();
        }

        void GradeAssignments()
        {
            Console.Clear();
            Console.WriteLine("Type the Assignment name in which you would like Grade");
            WriteLineAssignmentDictionary();
            string assignmentChoice = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter this assignment Grade from 0.0 - 100");
            double assignmentCurrentGrade = double.Parse((Console.ReadLine()));
            assignmentsDictionary[assignmentChoice].Grade = assignmentCurrentGrade;
            if (assignmentsDictionary == null)
            {
                EditStudentDetailsMenu();
            }
            else
            {
                if (assignmentCurrentGrade > HighestGrade)
                {
                    this.HighestGrade = assignmentCurrentGrade;
                    gradesListToAverageOut.Add(assignmentCurrentGrade);
                    this.Average = gradesListToAverageOut.Average();
                }
                else if (assignmentCurrentGrade < LowestGrade)
                {
                    this.LowestGrade = assignmentCurrentGrade;
                    gradesListToAverageOut.Add(assignmentCurrentGrade);
                    this.Average = gradesListToAverageOut.Average();
                }
                else
                {
                    EditStudentDetailsMenu();
                }
            }

            EditStudentDetailsMenu();
        }
    }
}
