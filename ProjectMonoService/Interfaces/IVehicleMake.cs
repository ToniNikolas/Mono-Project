using ProjectMonoService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectMonoService.Interfaces
{
   public interface IVehicleMake
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Abrv { get; set; }
        ICollection<VehicleModel> VehicleModels { get; set; }
    }
}
