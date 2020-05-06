using System;

namespace Shanlv.DomainModel
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; } = false;
        public int InspectId { get; set; } = 0;
        public DateTime InspectTime { get; set; } = DateTime.Now;
    }
}