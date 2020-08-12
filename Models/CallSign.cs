using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterChannelMap.Model
{
    public class CallSign
    {
        public int ID { get; set; }
        public string CallLetters { get; set; }
        public string Description { get; set; }
        public int ChannelListingID { get; set; }
        public string Notes { get; set; }
    }
}
