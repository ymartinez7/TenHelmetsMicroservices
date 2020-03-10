using TenHelmets.MS.Core.Entities;
using TenHelmets.MS.Core.Interfaces.Repositories;
using TenHelmets.MS.Core.Interfaces.Services;

namespace TenHelmets.MS.Core.Services
{
    public sealed class EventLogService : BaseService<EventLog>, IEventLogService
    {
        public EventLogService(IEventLogRepository eventLogRepository)
            : base(eventLogRepository)
        {

        }
    }
}
