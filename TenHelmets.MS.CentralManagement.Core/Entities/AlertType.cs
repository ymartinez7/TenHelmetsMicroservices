using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class AlertType : BaseEntity
    {
        public AlertType()
        {
            Alerts = new HashSet<Alert>();
            Activities = new HashSet<Activity>();
            Priorities = new HashSet<Priority>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Alert> Alerts { get; private set; }
        public virtual IEnumerable<Activity> Activities { get; private set; }
        public virtual IEnumerable<Priority> Priorities { get; private set; }
    }
}
