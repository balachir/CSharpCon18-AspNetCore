using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp_NetCore.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; private set; } = "Hello World. ";

        public void OnGet()
        {
            Message += $" Server time is { DateTime.Now }";
        }
    }
}