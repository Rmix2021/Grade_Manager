using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Grade_Manager_Razor.Data;
using Grade_Manager_Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grade_Manager_Razor
{
    public class ClassRoomService
    {
        readonly GradeManagerDbContext _context;
        readonly ILogger _logger;

        public ClassRoomService(GradeManagerDbContext context, ILoggerFactory factory)
        {
            _context = context;
            _logger = factory.CreateLogger<ClassRoomService>();
        }

        public async Task<List<DisplayClassRoomsViewModel>> GetClassRooms()
        {
            return await _context.ClassRooms
                .Where(c => c.IsDeleted)
                .Select(x => new DisplayClassRoomsViewModel
                {
                    Id = x.ClassRoomId,
                    Name = x.Name
                })
                .ToListAsync();
        }

        public async Task DeleteClassRoom(int classRoomId)
        {
            var classRoom = await _context.ClassRooms.FindAsync(classRoomId);
            if (classRoom is null) { throw new Exception("Unable to find recipe"); }

            classRoom.IsDeleted = true;
            await _context.SaveChangesAsync();
        }
    }
}
