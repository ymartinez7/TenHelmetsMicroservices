using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class ActionType : BaseEntity
    {
        public ActionType()
        {
            Cals = new HashSet<Cal>();
        }

        public string Name { get; set; }
        public virtual IEnumerable<Cal> Cals { get; private set; }
    }
}
