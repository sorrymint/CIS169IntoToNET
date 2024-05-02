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
    public class IndexModel : PageModel
    {
        private readonly CIS169IntroToNET.Data.CIS169IntroToNETContext _context;

        public IndexModel(CIS169IntroToNET.Data.CIS169IntroToNETContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Course = await _context.Course.ToListAsync();
        }
    }
}
