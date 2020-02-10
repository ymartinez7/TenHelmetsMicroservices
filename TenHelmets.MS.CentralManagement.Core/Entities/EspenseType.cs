namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class EspenseType : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public EspenseType()
        {
            this.Espenses = new HashSet<Espense>();
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
        public virtual IEnumerable<Espense> Espenses { get; private set; }
    }
}
