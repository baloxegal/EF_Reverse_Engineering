using System;
using System.Collections.Generic;

#nullable disable

namespace EF_Reverse_Engineering
{
    public partial class Sector
    {
        public Sector()
        {
            Packages = new HashSet<Package>();
        }

        public int SectorId { get; set; }
        public string SectorName { get; set; }

        public virtual ICollection<Package> Packages { get; set; }
    }
}
