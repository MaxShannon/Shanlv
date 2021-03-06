﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using Shanlv.DomainModel.DataModel.DataTableModel;
using Shanlv.DomainModel.ViewModel;

namespace Shanlv.DomainModel.DataModel.Extend
{
    public static class Extend
    {
        //public static TViewModel ToViewModel<TViewModel, TDataModel>(this TDataModel model)
        //    where TViewModel : class, new() where TDataModel : class, new()// T == UserViewModel
        //{
        //    var viewModel = new TViewModel();
        //    var viewModelType = typeof(TViewModel);
        //    var dataModelType = model.GetType();
        //    var dataModelProperties = dataModelType.GetProperties();
        //    foreach (var dataModelProperty in dataModelProperties)
        //    {
        //        var viewModelProperty = viewModelType.GetProperty(dataModelProperty.Name);
        //        if (viewModelProperty == null)
        //        {
        //            continue;
        //        }
        //        var value = dataModelProperty.GetValue(model);
        //        viewModelProperty.SetValue(viewModel, value);
        //    }
        //    return viewModel;
        //}

        public static TViewModel ToViewModel<TViewModel>(this object model)
        //where TViewModel : class, new()// T == UserViewModel
        {
            var viewModelType = typeof(TViewModel);
            var viewModel = Activator.CreateInstance<TViewModel>();//new TViewModel();
            var dataModelType = model.GetType();
            var dataModelProperties = dataModelType.GetProperties();
            foreach (var dataModelProperty in dataModelProperties)
            {
                // Set proproty value
                var viewModelProperty = viewModelType.GetProperty(dataModelProperty.Name);
                if (viewModelProperty == null)
                {
                    // Set class value
                    //var viewModelPropertyWithOtherData = viewModelType.GetProperty(dataModelProperty.Name + "Name");
                    //if (viewModelPropertyWithOtherData == null)
                    //{
                    //    continue;
                    //}

                    //var value = viewModelPropertyWithOtherData.GetValue(model);
                    //viewModelProperty.SetValue(viewModel, value);
                    continue;
                }
                var value = dataModelProperty.GetValue(model);
                viewModelProperty.SetValue(viewModel, value);
            }
            return viewModel;
        }

        public static IEnumerable<TViewModel> ToViewModels<TViewModel>(this IEnumerable<object> models)
        {
            List<TViewModel> viewModel = new List<TViewModel>();
            foreach (var model in models)
            {
                var item = model.ToViewModel<TViewModel>();
                viewModel.Add(item);
            }
            return viewModel;
        }
    }
}