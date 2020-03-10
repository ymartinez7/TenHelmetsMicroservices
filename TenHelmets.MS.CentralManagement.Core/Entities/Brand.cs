using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class Brand : BaseEntity
    {
        public Brand()
        {
            this.Resources = new HashSet<Resource>();
        }

        public string Name { get; set; }
        public virtual IEnumerable<Resource> Resources { get; private set; }
    }
}
