namespace TenHelmets.MS.Core.Services
{
    using TenHelmets.MS.Core.Entities;
    using TenHelmets.MS.Core.Interfaces.Repositories;
    using TenHelmets.MS.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class EventLogService : BaseService<EventLog>, IEventLogService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventLogRepository"></param>
        public EventLogService(IEventLogRepository eventLogRepository)
            : base(eventLogRepository)
        {

        }
    }
}
