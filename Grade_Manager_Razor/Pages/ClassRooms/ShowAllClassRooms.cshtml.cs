using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Grade_Manager_Razor.Models;

namespace Grade_Manager_Razor.Pages.ClassRooms
{
    public class ShowAllClassRoomsModel : PageModel
    {
        public DisplayClassRoomsViewModel ClassRoom { get; set; }
        private readonly ClassRoomService _service;

        public ShowAllClassRoomsModel(ClassRoomService service)
        {
            _service = service;
        }

       

        public async Task<IActionResult> onPostDeleteAsync(int id)
        {
            await _service.DeleteClassRoom(id);
            return RedirectToPage("/Index");
        }
        
    }
}
