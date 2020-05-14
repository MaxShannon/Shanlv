using System;
using Shanlv.DomainModel.DataModel.DataTableModel;
using Shanlv.DomainModel.DataModel.Extend;
using Shanlv.DomainModel.ViewModel;
using Shanlv.EfDbModels;
using Xunit;

namespace Shanlv.Bll.Tests.DataModel.Extend
{
    public class ExtendShould
    {
        public ExtendShould()
        {
          
        }

        [Fact]
        public void HaveTransToViewModelWhenThisCase() 
        {
            var dataModel = new Subsidiary
            {
                SubsidiaryName = "Test Subsidiary"
            };
            var viewModel = new SubsidiaryViewModel
            {
                SubsidiaryName = dataModel.SubsidiaryName
            };

            var resultViewModel = dataModel.ToViewModel<SubsidiaryViewModel>();

            Assert.Equal(viewModel.SubsidiaryName, resultViewModel.SubsidiaryName);
            //Assert.Equal(viewModel, resultViewModel);
        }
    }


}
