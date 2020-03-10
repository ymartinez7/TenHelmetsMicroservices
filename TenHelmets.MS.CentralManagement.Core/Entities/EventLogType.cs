using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class EventLogType : BaseEntity
    {
        public EventLogType()
        {
            this.EventLogs = new HashSet<EventLog>();
        }

        public string Name { get; set; }
        public virtual IEnumerable<EventLog> EventLogs { get; private set; }
    }
}
