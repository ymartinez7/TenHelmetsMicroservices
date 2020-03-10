using System;
using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class Request : BaseEntity
    {
        public Request()
        {
            this.ResourceRequests = new HashSet<ResourceRequest>();
        }

        public int RequestTypeId { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public DateTime RequiredDate { get; set; }
        public int EmployeeId { get; set; }
        public int PriorityId { get; set; }
        public int StatusId { get; set; }
        public bool Accomplish { get; set; }
        public DateTime EndDate { get; set; }
        public virtual RequestType RequestType { get; set; }
        public virtual Project Project { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual Status Status { get; set; }
        public virtual IEnumerable<ResourceRequest> ResourceRequests { get; private set; }
    }
}
