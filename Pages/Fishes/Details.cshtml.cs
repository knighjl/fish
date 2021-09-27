using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using myWebApp.Models;

namespace myWebApp.Pages.Fishes
{
    public class DetailsModel : PageModel
    {
        private readonly MyWebAppContext _context;

        public DetailsModel(MyWebAppContext context)
        {
            _context = context;
        }

        public Fish Fish { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Fish = await _context.Fish.FirstOrDefaultAsync(m => m.ID == id);

            if (Fish == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
