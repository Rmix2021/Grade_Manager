using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grade_Manager_Razor
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public Assignment Assignment { get; set; }
       
    }
}
