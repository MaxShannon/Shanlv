using System;
using System.ComponentModel.DataAnnotations;

namespace Shanlv.DomainModel.DataModel.BaseDataTableModel
{
    public class BaseEntity
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "是否删除")]
        public bool IsDelete { get; set; } = false;

        [Display(Name = "操作人")]
        public int InspectId { get; set; } = 0;
        [Display(Name = "操作时间")]
        public DateTime InspectTime { get; set; } = DateTime.Now;
    }
}