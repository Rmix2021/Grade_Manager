using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor.Pages.ClassRooms
{
    public class ShowAllClassRoomsModel : PageModel
    {
        public Dictionary<string, ClassRoom> ClassRoomDictionary { get; set; }

        private readonly ILogger<ShowAllClassRoomsModel> _logger;

        public ShowAllClassRoomsModel(ILogger<ShowAllClassRoomsModel> logger)
        {
            _logger = logger;


        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
        
    }
}
