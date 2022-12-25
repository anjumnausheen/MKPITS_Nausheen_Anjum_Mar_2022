using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Input_Form.Pages
{
    public class IndexModel : PageModel
    {
            public string StudentName{get;set; }

            public string UniversityName{get;set;}
        
           public string Address { get; set; }


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

    

        }
        public void OnPost()
        {
                StudentName = Request.Form["StudentName"];
                UniversityName = Request.Form["UniName"];
                Address = Request.Form["Address"];


        }

    }
}