﻿using System.Diagnostics.CodeAnalysis;
using ReactiveUI;
using FoodDeliverySystem.Abstractions;

namespace FoodDeliverySystem.Admin.ViewModels
{
    [ExcludeFromCodeCoverage]
    public abstract class BaseViewModel : ReactiveObject, INavigatableViewModel
    {
        private bool _isLoading;

        private string _title;

        public bool IsLoading
        {
            get => _isLoading;
            set => this.RaiseAndSetIfChanged(ref _isLoading, value);
        }

        public virtual string Title
        {
            get => _title;
            protected set => this.RaiseAndSetIfChanged(ref _title, value);
        }
    }
}