using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Grade_Manager_Razor.Pages
{
    public class AssignmentsModel : PageModel
    {
        private readonly ILogger<AssignmentsModel> _logger;

        public AssignmentsModel(ILogger<AssignmentsModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
