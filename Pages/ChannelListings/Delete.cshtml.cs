using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MasterChannelMap.Data;
using MasterChannelMap.Model;

namespace MasterChannelMap.Pages.ChannelListings
{
    public class DeleteModel : PageModel
    {
        private readonly MasterChannelMap.Data.MasterChannelMapContext _context;

        public DeleteModel(MasterChannelMap.Data.MasterChannelMapContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ChannelListing ChannelListing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ChannelListing = await _context.ChannelListings.FirstOrDefaultAsync(m => m.ID == id);

            if (ChannelListing == null)
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

            ChannelListing = await _context.ChannelListings.FindAsync(id);

            if (ChannelListing != null)
            {
                _context.ChannelListings.Remove(ChannelListing);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
