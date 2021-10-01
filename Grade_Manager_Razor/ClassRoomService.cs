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

        public List<ClassRoomSummaryViewModel> GetAllClassRooms()
        {
            //List<ClassRoom> classRooms = new List<ClassRoom>();
            
            return  _context.ClassRooms
                .Select(x => new ClassRoomSummaryViewModel
                {
                    Id = x.ClassRoomId,
                    Name = x.Name,
                })
                .ToList();
        }

        
    }
}
