using ProjectMonoService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectMonoService.ModelsInterface
{
   public interface IVehicleModel
    {
        Guid Id { get; set; }
        Guid MakeId { get; set; }
        string ModelName { get; set; }
        string Abrv { get; set; }
        VehicleMake VehicleMake { get; set; }
    }
}
