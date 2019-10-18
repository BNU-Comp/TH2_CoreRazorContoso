using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TH2_CoreRazerContoso.Models;

namespace TH2_CoreRazerContoso.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly TH2_CoreRazerContoso.Models.UniversityContext _context;

        public IndexModel(TH2_CoreRazerContoso.Models.UniversityContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
