namespace TenHelmets.MS.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class Rol : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Rol()
        {
            this.Employees = new HashSet<Employee>();
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int UnitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Unit Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Employee> Employees { get; private set; }
    }
}
