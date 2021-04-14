using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BiblioAttendant.Pages
{
    public enum Gender
    {
        male,
        female
    }

    public enum Platform
    {
        Windows,
        macOS,
        Linux,
        ChomeOS,
        Android,
        iOS
    }

    public class IndexModel : PageModel
    {

        public void OnGet()
        {
            
        }

        public void OnPost(bool check, string gender, Platform pc, Platform[] pc2)
        {
           
        }
    }
}
