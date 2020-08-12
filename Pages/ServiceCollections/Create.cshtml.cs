using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MasterChannelMap.Data;
using MasterChannelMap.Model;

namespace MasterChannelMap.Pages.ServiceCollections
{
    public class CreateModel : PageModel
    {
        private readonly MasterChannelMap.Data.MasterChannelMapContext _context;

        public CreateModel(MasterChannelMap.Data.MasterChannelMapContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ServiceCollection ServiceCollection { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ServiceCollections.Add(ServiceCollection);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
