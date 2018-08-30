using System.Linq;
using System.Reactive.Linq;
using System.Windows.Input;
using ReactiveUI;
using FoodDeliverySystem.Services;
using FoodDeliverySystem.Common.Admin.ViewModels;

namespace FoodDeliverySystem.Admin.ViewModels
{
    public class BasketViewModel : BaseViewModel
    {
        private ReactiveList<IOrderViewModel> _orders = new ReactiveList<IOrderViewModel> { ChangeTrackingEnabled = true };
        private readonly ObservableAsPropertyHelper<decimal> _totalPrice;
        private readonly ObservableAsPropertyHelper<string> _ordersCount;


        public decimal TotalPrice => _totalPrice.Value;

        public string OrdersCount => _ordersCount.Value;

        public ReactiveList<IOrderViewModel> Orders
        {
            get => _orders;
            set => this.RaiseAndSetIfChanged(ref _orders, value);
        }

        //public void AddOrder(IOrderViewModel order)
        //{
        //    _orders.Add(order.Clone());

        //    var groupedOrders = _orders
        //        .GroupBy(x => x.Food.Id)
        //        .Select(orders => new OrderViewModel(orders.Select(x => x.Food).FirstOrDefault(x => x.Id == orders.Key), orders.Sum(s => s.Quantity)));

        //    Orders = new ReactiveList<IOrderViewModel>(groupedOrders) { ChangeTrackingEnabled = true };
        //}

        public void RaiseOrdersCount()
        {
            this.RaisePropertyChanged(nameof(OrdersCount));
        }

        public ICommand CompleteOrder { get; }

        public override string Title => "Your basket";
    }
}