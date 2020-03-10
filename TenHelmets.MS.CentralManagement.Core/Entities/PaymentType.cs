using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class PaymentType : BaseEntity
    {
        public PaymentType()
        {
            this.Bills = new HashSet<Bill>();
            this.Purchases = new HashSet<Purchase>();
            this.Sales = new HashSet<Sale>();
        }

        public string Name { get; set; }
        public virtual IEnumerable<Bill> Bills { get; private set; }
        public virtual IEnumerable<Purchase> Purchases { get; private set; }
        public virtual IEnumerable<Sale> Sales { get; private set; }
    }
}
