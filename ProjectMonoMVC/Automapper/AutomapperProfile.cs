using AutoMapper;
using ProjectMonoService.Models;
using ProjectMonoMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using ProjectMonoService.Interfaces;

namespace ProjectMonoMVC.Automapper
{
   public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<IVehicleMake, VehicleMakeView>().ReverseMap();
            CreateMap<IVehicleModel, VehicleModelView>().ReverseMap();
            CreateMap<IVehicleMake, VehicleMake>().ReverseMap();
            CreateMap<IVehicleModel, VehicleModel>().ReverseMap();
        }
    }
}
