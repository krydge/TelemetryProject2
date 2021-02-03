using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TelemetryProject_.Pages
{
    public class FinalPageModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("./Index");
        }
        public IActionResult OnPostSecond()
        {
            return RedirectToPage("./page2");
        }
        public IActionResult OnPostThird()
        {
            return RedirectToPage("./page3");
        }

    }
}

