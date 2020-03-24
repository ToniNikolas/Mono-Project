using ProjectMonoService.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMonoService.Models
{
  
    public class VehicleMake : IVehicleMake
    { 
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Abrv { get; set; }
        public ICollection<VehicleModel> VehicleModels { get; set; }
    }
}
