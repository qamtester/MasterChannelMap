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
    public class DetailsModel : PageModel
    {
        private readonly MasterChannelMap.Data.MasterChannelMapContext _context;

        public DetailsModel(MasterChannelMap.Data.MasterChannelMapContext context)
        {
            _context = context;
        }

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
    }
}
