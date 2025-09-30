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
    public class IndexModel : PageModel
    {
        private readonly Vizallas.Data.VizallasDbContext _context;

        public IndexModel(Vizallas.Data.VizallasDbContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Class = await _context.Classes.ToListAsync();
        }
    }
}
