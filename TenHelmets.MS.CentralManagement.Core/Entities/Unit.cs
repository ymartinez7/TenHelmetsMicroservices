using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class Unit : BaseEntity
    {
        public Unit()
        {
            this.ProjectBudgets = new HashSet<ProjectBudget>();
            this.RequestTypes = new HashSet<RequestType>();
            this.Roles = new HashSet<Rol>();
            this.ServiceOrders = new HashSet<ServiceOrder>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual IEnumerable<ProjectBudget> ProjectBudgets { get; private set; }
        public virtual IEnumerable<RequestType> RequestTypes { get; private set; }
        public virtual IEnumerable<Rol> Roles { get; private set; }
        public virtual IEnumerable<ServiceOrder> ServiceOrders { get; private set; }
    }
}
