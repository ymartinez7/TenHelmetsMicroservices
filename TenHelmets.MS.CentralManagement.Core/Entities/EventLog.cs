namespace TenHelmets.MS.Core.Entities
{
    public class EventLog : BaseEntity
    {
        public int EventLogTypeId { get; set; }
        public string Description { get; set; }
        public virtual EventLogType EventLogType { get; set; }
    }
}
