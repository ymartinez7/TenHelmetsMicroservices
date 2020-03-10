using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class Model : BaseEntity
    {
        public Model()
        {
            this.SaleDetails = new HashSet<SaleDetail>();
        }

        public string Name { get; set; }
        public int Year { get; set; }
        public string Capacity { get; set; }
        public string Measure { get; set; }
        public int ResourceId { get; set; }
        public virtual Resource Resource { get; set; }
        public virtual IEnumerable<SaleDetail> SaleDetails { get; private set; }
    }
}
