﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grade_Manager_Razor
{
    public class ClassRoom
    {
        public int ClassRoomId { get; set; }
        public string Name { get; set; }      
        
        public Student Students{ get; set; }
      
    }
}
