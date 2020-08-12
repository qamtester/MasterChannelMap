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
    public class IndexModel : PageModel
    {
        private readonly MasterChannelMap.Data.MasterChannelMapContext _context;

        public IndexModel(MasterChannelMap.Data.MasterChannelMapContext context)
        {
            _context = context;
        }

        public IList<ServiceCollection> ServiceCollection { get;set; }

        public async Task OnGetAsync()
        {
            ServiceCollection = await _context.ServiceCollections.ToListAsync();
        }
    }
}
