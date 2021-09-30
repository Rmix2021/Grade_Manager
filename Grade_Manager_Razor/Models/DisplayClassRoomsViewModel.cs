using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grade_Manager_Razor.Data;

namespace Grade_Manager_Razor.Models
{
    public class DisplayClassRoomsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public static DisplayClassRoomsViewModel FromClassRoom(ClassRoom classRoom)
        {
            return new DisplayClassRoomsViewModel
            {
                Id = classRoom.ClassRoomId,
                Name =  classRoom.Name
            };
        }
    }
}
