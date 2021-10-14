using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grade_Manager_Razor.Data;
using Grade_Manager_Razor.Models;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor
{
    public class ClassRoomService
    {
        readonly GradeManagerDbContext _context;
        readonly ILogger _logger;

        public ClassRoomService(GradeManagerDbContext context, ILoggerFactory factory)
        {
            this._context = context;
            _logger = factory.CreateLogger<ClassRoomService>();
        }

        public List<ClassRoom> GetAllClassRooms()
        {
            

            var classroomList = _context.ClassRooms.ToList();
         
            return classroomList;

        }

        public void AddNewClassRoom(AddClassRoomViewModel name)
        {
            var classRoom = name.ToClassRoom();
            _context.Add(classRoom);
            _context.SaveChanges();
            
            
        }

        public ClassRoom GetFilteredClassRooms(int id)
        {
            return this._context.ClassRooms.Where(x => x.ClassRoomId == id).FirstOrDefault();
                
        }

       

    }
}
