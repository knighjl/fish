using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using myWebApp.Models;

namespace myWebApp.Pages.Fishes
{
    public class IndexModel : PageModel
    {
        private readonly MyWebAppContext _context;

        public IndexModel(MyWebAppContext context)
        {
            _context = context;
        }

        public IList<Fish> Fish { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            Fish = await _context.Fish.ToListAsync();
        }
    }
}
