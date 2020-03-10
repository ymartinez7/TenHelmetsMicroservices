using System;

namespace TenHelmets.MS.Core.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModificatedDate { get; set; }
    }
}
