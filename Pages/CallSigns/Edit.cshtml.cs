using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MasterChannelMap.Data;
using MasterChannelMap.Model;

namespace MasterChannelMap.Pages.CallSigns
{
    public class EditModel : PageModel
    {
        private readonly MasterChannelMap.Data.MasterChannelMapContext _context;

        public EditModel(MasterChannelMap.Data.MasterChannelMapContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CallSign).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CallSignExists(CallSign.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CallSignExists(int id)
        {
            return _context.CallSigns.Any(e => e.ID == id);
        }
    }
}
