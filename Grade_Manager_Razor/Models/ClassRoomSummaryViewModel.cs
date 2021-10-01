using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grade_Manager_Razor.Models
{
    public class ClassRoomSummaryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static ClassRoomSummaryViewModel FromClassRoom(ClassRoom classRoom)
        {
            return new ClassRoomSummaryViewModel
            {
                Id = classRoom.ClassRoomId,
                Name = classRoom.Name
            };
        }
    }
}
