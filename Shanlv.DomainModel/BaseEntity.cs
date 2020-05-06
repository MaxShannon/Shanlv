using System;

namespace Shanlv.DomainModel
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public int InspectId { get; set; }
        public DateTime InspectTime { get; set; }
    }
}