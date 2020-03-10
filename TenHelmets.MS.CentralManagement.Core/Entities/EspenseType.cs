using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class EspenseType : BaseEntity
    {
        public EspenseType()
        {
            this.Espenses = new HashSet<Espense>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Espense> Espenses { get; private set; }
    }
}
