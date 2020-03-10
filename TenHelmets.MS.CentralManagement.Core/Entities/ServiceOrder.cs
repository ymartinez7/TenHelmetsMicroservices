using System;
using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class ServiceOrder : BaseEntity
    {
        public ServiceOrder()
        {
            this.Projects = new HashSet<Project>();
            this.Files = new HashSet<File>();
        }

        public decimal Amount { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public int UnitId { get; set; }
        public DateTime ReceptionDate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual IEnumerable<Project> Projects { get; private set; }
        public virtual IEnumerable<File> Files { get; private set; }
    }
}
