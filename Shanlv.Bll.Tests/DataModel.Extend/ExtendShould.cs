using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

        [Fact]
        public void HaveTransToViewModelListWhenThisCase()
        {

            List<Subsidiary> dataModel = new List<Subsidiary>
            {
                new Subsidiary
                {
                    SubsidiaryName = "Test Subsidiary1"
                },
                new Subsidiary
                {
                    SubsidiaryName = "Test Subsidiary2"
                },
                new Subsidiary
                {
                    SubsidiaryName = "Test Subsidiary3"
                }
            };

            var enumDataModel = dataModel.AsEnumerable();

            var viewModel = new SubsidiaryViewModel
            {
                SubsidiaryName = dataModel.SubsidiaryName
            };

            var resultViewModel = dataModel.ToViewModel<IEnumerable<SubsidiaryViewModel>>();

            for (int i = 0; i < enumDataModel.l; i++)
            {
                
            }
            Assert.Equal(viewModel.SubsidiaryName, resultViewModel.SubsidiaryName);
            //Assert.Equal(viewModel, resultViewModel);
        }
    }


}
