using System;

namespace Shanlv.EfDbModels.DbTable
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public int InspectId { get; set; }
        public DateTime InspectTime{ get; set; }
    }
}