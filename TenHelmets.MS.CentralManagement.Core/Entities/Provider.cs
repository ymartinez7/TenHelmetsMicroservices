﻿using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class Provider : BaseEntity
    {
        public Provider()
        {
            this.Actiities = new HashSet<Activity>();
            this.Purchases = new HashSet<Purchase>();
        }

        public string Name { get; set; }
        public string Rif { get; set; }
        public string TaxAddress { get; set; }
        public int SectorId { get; set; }
        public string LocalNumber { get; set; }
        public string Email { get; set; }
        public virtual Sector Sector { get; set; }
        public virtual IEnumerable<Activity> Actiities { get; private set; }
        public virtual IEnumerable<Purchase> Purchases { get; private set; }
    }
}
