using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grade_Manager_Razor
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public string Name { get; set; }           
        public bool IsComplete { get; set; }

        private double _grade = 0;

        public double Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                Grade = value;
                if (Grade >= 0)
                {
                    IsComplete = true;
                }
            }
        }

       
    }
}
