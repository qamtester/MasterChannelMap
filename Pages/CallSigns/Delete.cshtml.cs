using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MasterChannelMap.Data;
using MasterChannelMap.Model;

namespace MasterChannelMap.Pages.CallSigns
{
    public class DeleteModel : PageModel
    {
        private readonly MasterChannelMap.Data.MasterChannelMapContext _context;

        public DeleteModel(MasterChannelMap.Data.MasterChannelMapContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CallSign CallSign { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CallSign = await _context.CallSigns.FirstOrDefaultAsync(m => m.ID == id);

            if (CallSign == null)
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

            CallSign = await _context.CallSigns.FindAsync(id);

            if (CallSign != null)
            {
                _context.CallSigns.Remove(CallSign);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
