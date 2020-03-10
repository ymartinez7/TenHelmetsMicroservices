using System.Collections.Generic;

namespace TenHelmets.MS.Core.Entities
{
    public class Priority : BaseEntity
    {
        public Priority()
        {
            this.Requests = new HashSet<Request>();
        }

        public string Name { get; set; }
        public int MinTM { get; set; }
        public int MaxTM { get; set; }
        public int AlertTypeId { get; set; }
        public virtual AlertType AlertType { get; set; }
        public virtual IEnumerable<Request> Requests { get; private set; }
    }
}
