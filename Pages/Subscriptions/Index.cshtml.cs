using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using crud.Data;
using crud.Models;

namespace crud.Pages_Subscriptions
{
    public class IndexModel : PageModel
    {
        private readonly crud.Data.ApplicationDbContext _context;

        public IndexModel(crud.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Subscription> Subscription { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Subscriptions != null)
            {
                Subscription = await _context.Subscriptions
                .Include(s => s.Student).ToListAsync();
            }
        }
    }
}
