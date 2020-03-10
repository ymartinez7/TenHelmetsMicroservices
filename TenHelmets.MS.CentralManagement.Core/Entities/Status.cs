using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class Status : BaseEntity
    {
        public Status()
        {
            this.Bills = new HashSet<Bill>();
            this.Espenses = new HashSet<Espense>();
            this.Cals = new HashSet<Cal>();
            this.Requests = new HashSet<Request>();
            this.Activities = new HashSet<Activity>();
            this.Projects = new HashSet<Project>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Bill> Bills { get; private set; }
        public virtual IEnumerable<Espense> Espenses { get; private set; }
        public virtual IEnumerable<Cal> Cals { get; private set; }
        public virtual IEnumerable<Request> Requests { get; private set; }
        public virtual IEnumerable<Activity> Activities { get; private set; }
        public virtual IEnumerable<Project> Projects { get; private set; }
    }
}
