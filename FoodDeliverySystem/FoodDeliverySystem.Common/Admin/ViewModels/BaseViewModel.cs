using System.Diagnostics.CodeAnalysis;
using ReactiveUI;

namespace FoodDeliverySystem.Admin.ViewModels
{
    [ExcludeFromCodeCoverage]
    public abstract class BaseViewModel : ReactiveObject
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