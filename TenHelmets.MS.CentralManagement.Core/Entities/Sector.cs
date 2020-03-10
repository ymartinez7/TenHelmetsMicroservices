using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class Sector : BaseEntity
    {
        public Sector()
        {
            this.Providers = new HashSet<Provider>();
            this.Customers = new HashSet<Customer>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Provider> Providers { get; private set; }
        public virtual IEnumerable<Customer> Customers { get; private set; }
    }
}
