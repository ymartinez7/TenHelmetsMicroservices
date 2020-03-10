using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class Rol : BaseEntity
    {
        public Rol()
        {
            this.Employees = new HashSet<Employee>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual IEnumerable<Employee> Employees { get; private set; }
    }
}
