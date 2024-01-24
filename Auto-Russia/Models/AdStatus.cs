using System;
using System.Collections.Generic;

namespace Auto_Russia.Models
{
    public partial class AdStatus
    {
        public AdStatus()
        {
            Advertisements = new HashSet<Advertisement>();
        }

        public int AdStatusId { get; set; }
        public string StatusName { get; set; } = null!;

        public virtual ICollection<Advertisement> Advertisements { get; set; }
    }
}
