using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class Resource : BaseEntity
    {
        public Resource()
        {
            this.SaleDetails = new HashSet<SaleDetail>();
            this.Models = new HashSet<Model>();
            this.ResourceRequests = new HashSet<ResourceRequest>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int ResourceTypeId { get; set; }
        public int BrandId { get; set; }
        public string SerialNumber { get; set; }
        public int Quantity { get; set; }
        public decimal UnitaryPrice { get; set; }
        public string State { get; set; }
        public virtual ResourceType ResourceType { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual IEnumerable<SaleDetail> SaleDetails { get; private set; }
        public virtual IEnumerable<Model> Models { get; private set; }
        public virtual IEnumerable<ResourceRequest> ResourceRequests { get; private set; }
    }
}
