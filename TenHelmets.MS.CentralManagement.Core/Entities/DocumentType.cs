using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class DocumentType : BaseEntity
    {
        public DocumentType()
        {
            this.Employees = new HashSet<Employee>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Employee> Employees { get; private set; }
    }
}
