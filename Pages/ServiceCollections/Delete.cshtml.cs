using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MasterChannelMap.Data;
using MasterChannelMap.Model;

namespace MasterChannelMap.Pages.ServiceCollections
{
    public class DeleteModel : PageModel
    {
        private readonly MasterChannelMap.Data.MasterChannelMapContext _context;

        public DeleteModel(MasterChannelMap.Data.MasterChannelMapContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ServiceCollection ServiceCollection { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ServiceCollection = await _context.ServiceCollections.FirstOrDefaultAsync(m => m.ID == id);

            if (ServiceCollection == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ServiceCollection = await _context.ServiceCollections.FindAsync(id);

            if (ServiceCollection != null)
            {
                _context.ServiceCollections.Remove(ServiceCollection);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
