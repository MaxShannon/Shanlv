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
                SubsidiaryName = "Test Subsidiary",
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

            List<User> dataModel = new List<User>
            {
                new User
                {
                    UserName = "Test UserName1",
                    su
                },
                new User
                {
                    UserName = "Test UserName2"
                },
                new User
                {
                    UserName = "Test UserName3"
                }
            };
            var enumDataModel = dataModel.AsEnumerable();

            List<UserViewModel> expectViewModel = new List<UserViewModel>
            {
                new UserViewModel
                {
                    UserName = dataModel[0].UserName,
                    SubsidiaryName = dataModel[0].Subsidiary.SubsidiaryName;
                },
                new UserViewModel
                {
                    SubsidiaryName = dataModel[1].SubsidiaryName
                },
                new UserViewModel
                {
                    SubsidiaryName = dataModel[2].SubsidiaryName
                }
            };
            var enumViewModel = viewModel.AsEnumerable();

            var resultViewModel = enumDataModel.ToViewModels<SubsidiaryViewModel>();

            var resultViewModels = resultViewModel as IEnumerable<SubsidiaryViewModel>;

            (resultViewModels .asl)
            for (int i = 0; i < resultViewModels.Count(); i++)
            {
                Assert.Equal(resultViewModels[i].SubsidiaryName, enumViewModels[i].SubsidiaryName);
            }

        }
    }


}
