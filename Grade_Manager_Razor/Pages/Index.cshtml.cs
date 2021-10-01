using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grade_Manager_Razor.Models;

namespace Grade_Manager_Razor.Pages
{
    public class IndexModel : PageModel

    {
        private readonly ClassRoomService _service;
        public List<ClassRoom> ClassRooms { get; private set; }

        public IndexModel(ClassRoomService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            ClassRooms = _service.GetAllClassRooms();
        }
    }
}
