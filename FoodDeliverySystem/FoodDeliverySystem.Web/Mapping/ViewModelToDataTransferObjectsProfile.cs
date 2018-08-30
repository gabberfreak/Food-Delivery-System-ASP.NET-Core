using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FoodDeliverySystem.Admin.ViewModels;
using FoodDeliverySystem.Common.Dtos;

namespace FoodDeliverySystem.Web.Mapping
{
    public class ViewModelToDataTransferObjectsProfile : Profile
    {
        public ViewModelToDataTransferObjectsProfile()
        {
            CreateMap<OrderViewModel, OrderItemDto>()
                .ForMember(x => x.Quantity, map => map.MapFrom(x => x.Quantity))
                .ForMember(x => x.FoodId, map => map.MapFrom(x => x.Food.Id));

            //TODO: Add user info mapping


            //TODO Add basket mapping
        }
    }
}
