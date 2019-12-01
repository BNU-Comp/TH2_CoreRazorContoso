using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TH2_CoreRazerContoso.Pages
{
    public class HelloModel : PageModel
    {
        public string UserName { get; set; }

        /// <summary>
        /// This will be called when the web page first
        /// loads.  It will set the name of the user to null
        /// </summary>
        public void OnGet()
        {
            UserName = null;
        }
        public void OnPost()
        {
            this.UserName = Request.Form["UserName"];
        }
    }
}
