using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliverySystem.Web.Mapping
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x => { x.AddProfile<ViewModelToDataTransferObjectsProfile>(); });
        }
    }
}
