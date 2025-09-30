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
    public class DetailsModel : PageModel
    {
        private readonly Vizallas.Data.VizallasDbContext _context;

        public DetailsModel(Vizallas.Data.VizallasDbContext context)
        {
            _context = context;
        }

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
    }
}
