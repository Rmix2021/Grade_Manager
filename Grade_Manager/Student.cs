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
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"Assignment Name: {kvp.Value.Name}                               "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"Assignment Grade: {kvp.Value.Grade}                             "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"Assignment Completion Status: {kvp.Value.CompletionStatus} +  /n"));
            }
        }

        public void EditStudentDetailsMenu()
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "******Edit Student Details Menu********"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Currently Editing 'Student xyz'        "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "1. Show Student Summary.               "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "2. Assign Student New Assignment.      "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "3. Show Assignments.                   "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "4. Grade Assignments.                  "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "5. Show students Best Grade.           "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "6. Show students worst Grade.          "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "9. Exit this menu.                     "));
            Console.SetCursorPosition(21, 10);

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
            Console.ReadLine();
            EditStudentDetailsMenu();

        }


        void AssignNewAssignment()
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Name the assignment in which you would like to add."));
            Console.SetCursorPosition(21, 9);

            string assignmentName = Console.ReadLine().ToUpper();
            assignmentsDictionary.Add(assignmentName, new Assignment(assignmentName));

            EditStudentDetailsMenu();
        }


        void ShowAssignments()
        {
            Console.Clear();
            WriteLineAssignmentDictionary();
            Console.ReadLine();
            EditStudentDetailsMenu();
        }


        void ShowStudentBestGrade()
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", HighestGrade));
            Console.ReadLine();
            EditStudentDetailsMenu();
        }


        void ShowStudentWorstGrade()
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", LowestGrade));
            Console.ReadLine();
            EditStudentDetailsMenu();
        }

        void GradeAssignments()
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Type the Assignment name in which you would like Grade"));
            WriteLineAssignmentDictionary();
            string assignmentChoice = Console.ReadLine().ToUpper();
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Enter this assignments Grade from 0.0 - 100"));
            double assignmentCurrentGrade = Convert.ToDouble(Console.ReadLine());
            assignmentsDictionary[assignmentChoice].Grade = assignmentCurrentGrade;

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
            EditStudentDetailsMenu();
        }
    }
}
