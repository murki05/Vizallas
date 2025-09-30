using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vizallas.Data;
using Vizallas.Model;

namespace Vizallas.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Vizallas.Data.VizallasDbContext _context;

        public DeleteModel(Vizallas.Data.VizallasDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Class Class { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var class = await _context.Classes.FirstOrDefaultAsync(m => m.Id == id);

            if (class == null)
            {
                return NotFound();
            }
            else
            {
                Class = class;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var class = await _context.Classes.FindAsync(id);
            if (class != null)
            {
                Class = class;
                _context.Classes.Remove(Class);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
