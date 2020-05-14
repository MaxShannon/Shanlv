using System.ComponentModel.DataAnnotations;
using Shanlv.DomainModel.DataModel.DataTableModel;

namespace Shanlv.DomainModel.ViewModel
{
    public class SubsidiaryViewModel
    {
        [Display(Name = "单位名")]
        public int SubsidiaryId { get; set; }

        [Display(Name = "单位名")]
        public string SubsidiaryName { get; set; }

        public Subsidiary ToSubsidiary()
        {
            var subsidiary = new Subsidiary();
            subsidiary.Id = SubsidiaryId;
            subsidiary.SubsidiaryName = SubsidiaryName;
            return subsidiary;
        }
    }
}