using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliverySystem.Common.Admin.ViewModels
{
    public interface IUserViewModel
    {
        string Email { get; set; }
        IUserInfoViewModel UserInfoViewModel { get; set; }
    }
}
