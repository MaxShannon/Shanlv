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
                    //Subsidiary = new Subsidiary(){ SubsidiaryName = "SubsidiaryName1"}
                },
                new User
                {
                    UserName = "Test UserName2",
                     //Subsidiary = new Subsidiary(){ SubsidiaryName = "SubsidiaryName2"}
                },
                new User
                {
                    UserName = "Test UserName3",
                    //Subsidiary = new Subsidiary(){ SubsidiaryName = "SubsidiaryName3"}
                }
            };
            var enumDataModel = dataModel.AsEnumerable();
            var resultViewModel = enumDataModel.ToViewModels<UserViewModel>();
            var resultViewModels = resultViewModel.ToList();

            List<UserViewModel> expectViewModel = new List<UserViewModel>
            {
                new UserViewModel
                {
                    UserName = dataModel[0].UserName,
                    //SubsidiaryName = dataModel[0].Subsidiary.SubsidiaryName
                },
                new UserViewModel
                {
                     UserName = dataModel[1].UserName,
                    //SubsidiaryName = dataModel[1].Subsidiary.SubsidiaryName
                },
                new UserViewModel
                {
                     UserName = dataModel[2].UserName,
                    //SubsidiaryName = dataModel[2].Subsidiary.SubsidiaryName
                }
            };

            for (int i = 0; i < resultViewModels.Count; i++)
            {
                //Assert.Equal(expectViewModel[i].SubsidiaryName, resultViewModels[i].SubsidiaryName);
                Assert.Equal(expectViewModel[i].UserName, resultViewModels[i].UserName);
            }

        }
    }


}
