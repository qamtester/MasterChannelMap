using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterChannelMap.Model
{
    public class ChannelListing
    {
        public int ID { get; set; }
        public string ChannelMapName { get; set; }
        public int TunerPosition { get; set; }
        public int CallSignID { get; set; }
        public int ServiceCollectionID { get; set; }

    }
}
