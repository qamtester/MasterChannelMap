using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MasterChannelMap.Model;

namespace MasterChannelMap.Data
{
    public class MasterChannelMapContext : DbContext
    {
        public MasterChannelMapContext (DbContextOptions<MasterChannelMapContext> options)
            : base(options)
        {
        }

        public DbSet<MasterChannelMap.Model.CallSign> CallSigns { get; set; }

        public DbSet<MasterChannelMap.Model.ChannelListing> ChannelListings { get; set; }

        public DbSet<MasterChannelMap.Model.ServiceCollection> ServiceCollections { get; set; }
    }
}
