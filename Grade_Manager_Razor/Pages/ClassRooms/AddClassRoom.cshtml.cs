using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor.Pages.ClassRooms
{
    public class AddClassRoomModel : PageModel
    {

        //[BindProperty]
        //public AddClassRoomCommand Input { get; set; }
        //private readonly 

        private readonly ILogger<AddClassRoomModel> _logger;

        public AddClassRoomModel(ILogger<AddClassRoomModel> logger)
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
