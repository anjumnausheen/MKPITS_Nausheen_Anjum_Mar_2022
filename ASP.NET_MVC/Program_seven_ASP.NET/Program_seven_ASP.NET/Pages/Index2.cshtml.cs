using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Program_seven_ASP.NET.Pages
{
    public class Index2Model : PageModel
    {
        public string Abc { get; set; }
        public string age { get; set; }
        public void OnGet()
        {
            Abc = "Abc String from Get method";
        }
        public void OnPost()
        {
            Abc = Request.Form["text1"];
            age = Request.Form["text3"];
            // do something with emailAddress
        }
    }
}
