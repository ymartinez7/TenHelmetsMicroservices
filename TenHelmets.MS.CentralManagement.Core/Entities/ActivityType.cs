using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class ActivityType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Activity> Activity { get; private set; }
    }
}
