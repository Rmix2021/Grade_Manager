using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor.Pages.Students
{
    public class ShowAllStudentsModel : PageModel
    {
        

        private readonly ILogger<ShowAllStudentsModel> _logger;

        public ShowAllStudentsModel(ILogger<ShowAllStudentsModel> logger)
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
