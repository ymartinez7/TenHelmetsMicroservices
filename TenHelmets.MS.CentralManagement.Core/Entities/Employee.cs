using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class Employee : BaseEntity
    {
        public Employee()
        {
            this.Espenses = new HashSet<Espense>();
            this.Purchases = new HashSet<Purchase>();
            this.Sales = new HashSet<Sale>();
            this.Cals = new HashSet<Cal>();
            this.ProjectBudgets = new HashSet<ProjectBudget>();
            this.Requests = new HashSet<Request>();
            this.Activities = new HashSet<Activity>();
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string FirstSureName { get; set; }
        public string SecondSureName { get; set; }
        public int DocumentTypeId { get; set; }
        public string Document { get; set; }
        public int RolId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual Rol Rol { get; set; }
        public virtual IEnumerable<Espense> Espenses { get; private set; }
        public virtual IEnumerable<Purchase> Purchases { get; private set; }
        public virtual IEnumerable<Sale> Sales { get; private set; }
        public virtual IEnumerable<Cal> Cals { get; private set; }
        public virtual IEnumerable<ProjectBudget> ProjectBudgets { get; private set; }
        public virtual IEnumerable<Request> Requests { get; private set; }
        public virtual IEnumerable<Activity> Activities { get; private set; }
    }
}
