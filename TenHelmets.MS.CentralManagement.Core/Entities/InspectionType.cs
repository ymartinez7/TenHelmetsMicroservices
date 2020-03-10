using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class InspectionType : BaseEntity
    {
        public InspectionType()
        {
            this.Inspections = new HashSet<Inspection>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Inspection> Inspections { get; private set; }
    }
}
