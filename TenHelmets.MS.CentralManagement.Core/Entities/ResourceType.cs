using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class ResourceType : BaseEntity
    {
        public ResourceType()
        {
            this.Resources = new HashSet<Resource>();
        }

        public string Name { get; set; }
        public virtual IEnumerable<Resource> Resources { get; private set; }
    }
}
