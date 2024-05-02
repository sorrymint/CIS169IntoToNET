using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIS169IntroToNET.Data;
using CIS169IntroToNET.Model;

namespace CIS169IntroToNET.Pages.Courses
{
    public class DetailsModel : PageModel
    {
        private readonly CIS169IntroToNET.Data.CIS169IntroToNETContext _context;

        public DetailsModel(CIS169IntroToNET.Data.CIS169IntroToNETContext context)
        {
            _context = context;
        }

        public Course Course { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course.FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }
            else
            {
                Course = course;
            }
            return Page();
        }
    }
}
