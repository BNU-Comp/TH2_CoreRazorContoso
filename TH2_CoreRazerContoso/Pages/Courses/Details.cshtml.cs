using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TH2_CoreRazerContoso.Models;

namespace TH2_CoreRazerContoso.Pages.Courses
{
    public class DetailsModel : PageModel
    {
        private readonly TH2_CoreRazerContoso.Models.UniversityContext _context;

        public DetailsModel(TH2_CoreRazerContoso.Models.UniversityContext context)
        {
            _context = context;
        }

        public Course Course { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course = await _context.Course.FirstOrDefaultAsync(m => m.CourseID == id);

            if (Course == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
